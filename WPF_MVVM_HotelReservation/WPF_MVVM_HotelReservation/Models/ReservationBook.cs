using System.Collections.Generic;

namespace WPF_MVVM_HotelReservation.Models
{
    public class ReservationBook
    {
        public Dictionary<RoomId, List<Reservation>> RoomsToReservations { get; set; }
    }
}
