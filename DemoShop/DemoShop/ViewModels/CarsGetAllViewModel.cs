using System.Collections.Generic;
using DemoShop.Data.Models;

namespace DemoShop.ViewModels
{
    public class CarsGetAllViewModel
    {
        public IEnumerable<Car> Cars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
