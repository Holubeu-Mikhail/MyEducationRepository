using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM_HotelReservation.Exceptions;
using WPF_MVVM_HotelReservation.Models;
using WPF_MVVM_HotelReservation.Services;
using WPF_MVVM_HotelReservation.Stores;
using WPF_MVVM_HotelReservation.ViewModels;

namespace WPF_MVVM_HotelReservation.Commands
{
    public class MakeReservationCommand : BaseCommandAsync
    {
        private readonly HotelStore _hotelStore;
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly NavigationService _reservationListingViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, HotelStore hotelStore, NavigationService reservationListingViewNavigationService)
        {
            _hotelStore = hotelStore;
            _makeReservationViewModel = makeReservationViewModel;
            _reservationListingViewNavigationService = reservationListingViewNavigationService;

            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) || 
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            var reservation = new Reservation(
                new RoomId(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate);

            try
            {
                await _hotelStore.MakeReservation(reservation);
                MessageBox.Show("Successfully reserved room.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _reservationListingViewNavigationService.Navigate();
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This room is already taken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);     
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to make reservation", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
