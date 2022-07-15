using System.Threading.Tasks;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Services.ReservationCreators
{
    public interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
