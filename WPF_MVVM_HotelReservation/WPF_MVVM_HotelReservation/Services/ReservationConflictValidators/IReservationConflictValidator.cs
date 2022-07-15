using System.Threading.Tasks;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Services.ReservationConflictValidators
{
    public interface IReservationConflictValidator
    {
        Task<Reservation> GetConflictingReservation(Reservation reservation);
    }
}
