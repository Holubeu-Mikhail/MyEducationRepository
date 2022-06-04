using System.Collections.Generic;
using System.Linq;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoShop.Data.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Car> Cars => _appDbContext.Car.Include(x => x.Category);

        public IEnumerable<Car> GetFavorite => _appDbContext.Car.Where(x => x.IsFavorite).Include(x => x.Category);

        public Car Get(int id) => _appDbContext.Car.FirstOrDefault(x => x.Id == id);
    }
}
