using System;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM_HotelReservation.Models;
using WPF_MVVM_HotelReservation.Stores;
using WPF_MVVM_HotelReservation.ViewModels;

namespace WPF_MVVM_HotelReservation.Commands
{
    public class LoadReservationsCommand : BaseCommandAsync
    {
        private readonly ReservationListingViewModel _viewModel;
        private readonly HotelStore _hotelStore;

        public LoadReservationsCommand(ReservationListingViewModel viewModel, HotelStore hotelStore)
        {
            _viewModel = viewModel;
            _hotelStore = hotelStore;
        }

        public async override Task ExecuteAsync(object parameter)
        {
            _viewModel.ErrorMessage = string.Empty;
            _viewModel.IsLoading = true;

            try
            {
                await _hotelStore.Load();

                _viewModel.UpdateReservations(_hotelStore.Reservations);
            }
            catch (Exception)
            {
                _viewModel.ErrorMessage = "Failed to load reservations.";
            }
            _viewModel.IsLoading = false;
        }
    }
}
