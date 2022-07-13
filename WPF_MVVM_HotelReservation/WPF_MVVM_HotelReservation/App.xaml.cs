using System;
using System.Collections.Generic;
using System.Windows;
using WPF_MVVM_HotelReservation.Exceptions;
using WPF_MVVM_HotelReservation.Models;
using WPF_MVVM_HotelReservation.Services;
using WPF_MVVM_HotelReservation.Stores;
using WPF_MVVM_HotelReservation.ViewModels;

namespace WPF_MVVM_HotelReservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Caesar's Palace");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
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
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, CreateReservationListingViewModel));
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return new ReservationListingViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
