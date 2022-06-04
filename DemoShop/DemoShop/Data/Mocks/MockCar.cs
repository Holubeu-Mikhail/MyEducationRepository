using System;
using System.Collections.Generic;
using System.Linq;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;

namespace DemoShop.Data.Mocks
{
    public class MockCar : ICarRepository
    {
        private readonly ICategoryRepository _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                var result = new List<Car>
                {
                    new Car { 
                        Name = "Tesla Model S", 
                        ShortDesc = "Fast and silent", 
                        LongDesc = "Good sedan for casual life with electric engine", 
                        Image = "/img/tesla.jpg", 
                        Price = 45000, 
                        IsFavorite = true,
                        Available = true, 
                        Category = _carsCategory.GetAll.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow and silent",
                        LongDesc = "Good sedan for casual life with default engine",
                        Image = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavorite = false,
                        Available = true,
                        Category = _carsCategory.GetAll.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDesc = "Fast and stylish",
                        LongDesc = "Good sedan for fast city driving",
                        Image = "/img/bmwm3.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAll.Last()
                    },
                    new Car {
                        Name = "Mercedes S class",
                        ShortDesc = "Comfortable and luxury",
                        LongDesc = "Good luxury sedan with electric engine for businessmen",
                        Image = "/img/w140.jpg",
                        Price = 85000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAll.Last()
                    }
                };
                return result;
            }
        }
        public IEnumerable<Car> GetFavorite { get; set; }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
