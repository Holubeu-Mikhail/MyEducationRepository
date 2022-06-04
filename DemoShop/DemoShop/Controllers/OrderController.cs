using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Cart _cart;

        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _cart.CartItems = _cart.GetCartItems();

            if (_cart.CartItems.Count == 0)
            {
                ModelState.AddModelError("", "No cars in your cart");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.Create(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order confirmed";
            return View();
        }
    }
}
