using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WPF_MVVM_HotelReservation.DbContexts
{
    public class HotelReservationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<HotelReservationDbContext>
    {
        public HotelReservationDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=hotelReservation.db").Options;

            return new HotelReservationDbContext(options);
        }
    }
}
