using System;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;

namespace DemoShop.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Cart _cart;

        public OrderRepository(AppDbContext appDbContext, Cart cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public void Create(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDbContext.Order.Add(order);

            var items = _cart.CartItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail { CarId = item.Car.Id, OrderId = order.Id, Price = item.Car.Price, Order = order, Car = item.Car };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
