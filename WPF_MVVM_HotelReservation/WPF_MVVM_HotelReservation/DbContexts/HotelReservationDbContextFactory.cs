﻿using Microsoft.EntityFrameworkCore;

namespace WPF_MVVM_HotelReservation.DbContexts
{
    public class HotelReservationDbContextFactory
    {
        private readonly string _connectionString;

        public HotelReservationDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public HotelReservationDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new HotelReservationDbContext(options);
        }
    }
}
