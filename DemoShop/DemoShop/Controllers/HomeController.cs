using DemoShop.Data.Interfaces;
using DemoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Cars'n'bids";

            var homeCars = new HomeViewModel() { FavoriteCars = _carRepository.GetFavorite };
            return View(homeCars);
        }
    }
}
