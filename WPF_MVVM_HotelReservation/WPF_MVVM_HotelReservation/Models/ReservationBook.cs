using System.Collections.Generic;
using System.Linq;
using WPF_MVVM_HotelReservation.Exceptions;

namespace WPF_MVVM_HotelReservation.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            var result = _reservations;
            return result;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
