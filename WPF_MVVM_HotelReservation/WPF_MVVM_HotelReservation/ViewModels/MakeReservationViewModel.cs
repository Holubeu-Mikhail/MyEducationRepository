using System;
using System.Windows.Input;
using WPF_MVVM_HotelReservation.Commands;
using WPF_MVVM_HotelReservation.Models;
using WPF_MVVM_HotelReservation.Services;
using WPF_MVVM_HotelReservation.Stores;

namespace WPF_MVVM_HotelReservation.ViewModels
{
    public class MakeReservationViewModel : BaseViewModel
    {
        private string _username = "Username";
        private int _roomNumber = 1;
        private int _floorNumber = 1;
        private DateTime _startDate = new DateTime(2022, 1, 1);
        private DateTime _endDate = new DateTime(2022, 1, 8);

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, NavigationService reservationListingViewNavigationService)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel, reservationListingViewNavigationService);
            CancelCommand = new NavigateCommand(reservationListingViewNavigationService);
        }
    }
}
