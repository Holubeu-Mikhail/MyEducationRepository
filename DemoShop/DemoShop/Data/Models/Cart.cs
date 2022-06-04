using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DemoShop.Data.Models
{
    public class Cart
    {
        private readonly AppDbContext _appDbContext;

        public Cart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string Id { get; set; }

        public List<CartItem> CartItems { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            var session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            var context = services.GetService<AppDbContext>();
            var cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            var result = new Cart(context) { Id = cartId };
            return result;
        }

        public void Add(Car car)
        {
            _appDbContext.CartItem.Add(new CartItem
            {
                CartId = Id,
                Car = car,
                Price = car.Price
            });

            _appDbContext.SaveChanges();
        }

        public List<CartItem> GetCartItems()
        {
            var result = _appDbContext.CartItem.Where(x => x.CartId == Id).Include(x => x.Car).ToList();
            return result;
        }
    }
}
