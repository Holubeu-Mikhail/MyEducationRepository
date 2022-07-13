using System;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        private readonly Reservation _reservation;

        public string RoomId => _reservation.RoomId?.ToString();

        public string Username => _reservation.Username;

        public string StartDate => _reservation.StartTime.Date.ToString("d");

        public string EndDate => _reservation.EndTime.Date.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
