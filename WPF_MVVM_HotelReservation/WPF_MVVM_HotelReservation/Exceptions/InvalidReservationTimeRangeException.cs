using System;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Exceptions
{
    public class InvalidReservationTimeRangeException : Exception
    {
        public Reservation Reservation { get; }

        public InvalidReservationTimeRangeException(Reservation reservation)
        {
            Reservation = reservation;
        }
    }
}
