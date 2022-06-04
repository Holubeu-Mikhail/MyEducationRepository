using System.Linq;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;
using DemoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly Cart _cart;

        public CartController(ICarRepository carRepository, Cart cart)
        {
            _carRepository = carRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Cars'n'bids";

            var items = _cart.GetCartItems();
            _cart.CartItems = items;

            var cartViewModel = new CartViewModel() { Cart = _cart };

            return View(cartViewModel);
        }

        public RedirectToActionResult Add(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(c => c.Id == id);

            if (item != null)
            {
                _cart.Add(item);
            }

            return RedirectToAction("Index");
        }
    }
}
