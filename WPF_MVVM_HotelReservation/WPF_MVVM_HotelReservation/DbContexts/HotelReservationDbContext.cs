using Microsoft.EntityFrameworkCore;
using WPF_MVVM_HotelReservation.DTOs;

namespace WPF_MVVM_HotelReservation.DbContexts
{
    public class HotelReservationDbContext : DbContext
    {
        public HotelReservationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ReservationDto> Reservations { get; set; }
    }
}
