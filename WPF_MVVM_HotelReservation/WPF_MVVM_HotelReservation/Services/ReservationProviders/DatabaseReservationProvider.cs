using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_MVVM_HotelReservation.DbContexts;
using WPF_MVVM_HotelReservation.DTOs;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Services.ReservationProviders
{
    public class DatabaseReservationProvider : IReservationProvider
    {
        private readonly HotelReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(HotelReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using HotelReservationDbContext context = _dbContextFactory.CreateDbContext();
            IEnumerable<ReservationDto> reservationDtos = await context.Reservations.ToListAsync();

            await Task.Delay(2000);

            return reservationDtos.Select(r => MapToReservation(r));
        }

        private Reservation MapToReservation(ReservationDto reservationDto)
        {
            return new Reservation(new RoomId(reservationDto.FloorNumber, reservationDto.RoomNumber), reservationDto.Username, reservationDto.StartTime, reservationDto.EndTime);
        }
    }
}
