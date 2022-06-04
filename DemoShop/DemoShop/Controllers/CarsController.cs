using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;
using DemoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarRepository _cars;
        private readonly ICategoryRepository _categories;
        private string _category;

        public CarsController(ICarRepository cars, ICategoryRepository categories)
        {
            _cars = cars;
            _categories = categories;
        }

        [Route("Cars/GetAll")]
        [Route("Cars/GetAll/{category}")]
        public ViewResult GetAll(string category = null)
        {
            _category = category;

            var tuple = GetCarsByCategory(category);

            var car = new CarsGetAllViewModel { Cars = tuple.Item1, CurrentCategory = tuple.Item2 };

            ViewBag.Title = "Cars'n'bids";
            return View(car);
        }

        private Tuple<IEnumerable<Car>, string> GetCarsByCategory(string category)
        {
            IEnumerable<Car> cars = new List<Car>();
            var currentCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _cars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Electric", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.Cars.Where(i => i.Category.Name.Equals("Electric car")).OrderBy(i => i.Id);
                    currentCategory = string.Format($"{category} cars");
                }
                else
                {
                    if (string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _cars.Cars.Where(i => i.Category.Name.Equals("Fuel car")).OrderBy(i => i.Id);
                        currentCategory = string.Format($"{category} cars");
                    }
                }
            }

            return Tuple.Create(cars, currentCategory);
        }
    }
}
