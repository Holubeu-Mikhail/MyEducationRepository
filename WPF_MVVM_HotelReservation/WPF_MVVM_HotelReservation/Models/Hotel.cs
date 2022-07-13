using System.Collections.Generic;

namespace WPF_MVVM_HotelReservation.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            var result = _reservationBook.GetAllReservations();
            return result;
        }

        public void AddReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
