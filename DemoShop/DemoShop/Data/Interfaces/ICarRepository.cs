using System.Collections.Generic;
using DemoShop.Data.Models;

namespace DemoShop.Data.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetFavorite { get; }

        Car Get(int id);
    }
}
