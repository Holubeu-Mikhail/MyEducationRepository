using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WPF_MVVM_HotelReservation.DbContexts;
using WPF_MVVM_HotelReservation.DTOs;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Services.ReservationConflictValidators
{
    public class DatabaseReservationConflictValidator : IReservationConflictValidator
    {
        private readonly HotelReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationConflictValidator(HotelReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Reservation> GetConflictingReservation(Reservation reservation)
        {
            using (HotelReservationDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDto reservationDto = await context.Reservations
                    .Where(r => r.FloorNumber == reservation.RoomId.FloorNumber)
                    .Where(r => r.RoomNumber == reservation.RoomId.RoomNumber)
                    .Where(r => r.EndTime > reservation.StartTime)
                    .Where(r => r.StartTime < reservation.EndTime)
                    .FirstOrDefaultAsync();

                if (reservationDto == null)
                {
                    return null;
                }

                return MapToReservation(reservationDto);
            }
        }

        private Reservation MapToReservation(ReservationDto reservationDto)
        {
            return new Reservation(new RoomId(reservationDto.FloorNumber, reservationDto.RoomNumber), reservationDto.Username, reservationDto.StartTime, reservationDto.EndTime);
        }
    }
}
