using System;

namespace WPF_MVVM_HotelReservation.Models
{
    public class Reservation
    {
        public RoomId RoomId { get; }

        public DateTime StartTime { get; }

        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);
    }
}
