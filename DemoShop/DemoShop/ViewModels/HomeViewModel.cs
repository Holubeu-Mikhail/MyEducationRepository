using System.Collections.Generic;
using DemoShop.Data.Models;

namespace DemoShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavoriteCars { get; set; }
    }
}
