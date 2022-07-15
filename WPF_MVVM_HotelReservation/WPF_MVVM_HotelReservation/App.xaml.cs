using Microsoft.EntityFrameworkCore;
using System.Windows;
using WPF_MVVM_HotelReservation.DbContexts;
using WPF_MVVM_HotelReservation.Models;
using WPF_MVVM_HotelReservation.Services;
using WPF_MVVM_HotelReservation.Services.ReservationConflictValidators;
using WPF_MVVM_HotelReservation.Services.ReservationCreators;
using WPF_MVVM_HotelReservation.Services.ReservationProviders;
using WPF_MVVM_HotelReservation.Stores;
using WPF_MVVM_HotelReservation.ViewModels;

namespace WPF_MVVM_HotelReservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConnectionString = "Data Source=hotelReservation.db";
        private const string HotelName = "Caesar's Palace";

        private readonly Hotel _hotel;
        private readonly HotelStore _hotelStore;
        private readonly NavigationStore _navigationStore;
        private readonly HotelReservationDbContextFactory _hotelReservationDbContextFactory;

        public App()
        {
            _hotelReservationDbContextFactory = new HotelReservationDbContextFactory(ConnectionString);

            IReservationProvider reservationProvider = new DatabaseReservationProvider(_hotelReservationDbContextFactory);
            IReservationCreator reservationCreator = new DatabaseReservationCreator(_hotelReservationDbContextFactory);
            IReservationConflictValidator reservationConflictValidator = new DatabaseReservationConflictValidator(_hotelReservationDbContextFactory);

            ReservationBook reservationBook = new ReservationBook(reservationProvider, reservationCreator, reservationConflictValidator);

            _hotel = new Hotel(HotelName, reservationBook);
            _hotelStore = new HotelStore(_hotel);
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using (HotelReservationDbContext dbContext = _hotelReservationDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreateReservationListingViewModel();

            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotelStore, new NavigationService(_navigationStore, CreateReservationListingViewModel));
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return ReservationListingViewModel.LoadViewModel(_hotelStore, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
