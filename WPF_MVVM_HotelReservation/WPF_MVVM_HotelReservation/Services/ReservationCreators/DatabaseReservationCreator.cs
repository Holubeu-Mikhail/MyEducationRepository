using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WPF_MVVM_HotelReservation.DbContexts;
using WPF_MVVM_HotelReservation.DTOs;
using WPF_MVVM_HotelReservation.Models;

namespace WPF_MVVM_HotelReservation.Services.ReservationCreators
{
    public class DatabaseReservationCreator : IReservationCreator
    {
        private readonly HotelReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationCreator(HotelReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateReservation(Reservation reservation)
        {
            using HotelReservationDbContext context = _dbContextFactory.CreateDbContext();
            ReservationDto reservationDto = MapToReservationDto(reservation);

            context.Reservations.Add(reservationDto);
            await context.SaveChangesAsync();
        }

        private ReservationDto MapToReservationDto(Reservation reservation)
        {
            ReservationDto result = new ReservationDto()
            {
                FloorNumber = reservation.RoomId?.FloorNumber ?? 0,
                RoomNumber = reservation.RoomId?.RoomNumber ?? 0,
                Username = reservation.Username,
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime
            };
            return result;
        }
    }
}
