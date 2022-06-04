using System.Collections.Generic;
using DemoShop.Data.Interfaces;
using DemoShop.Data.Models;

namespace DemoShop.Data.Mocks
{
    public class MockCategory : ICategoryRepository
    {
        public IEnumerable<Category> GetAll
        {
            get
            {
                var result = new List<Category>
                {
                    new Category() { Name = "Electric car", Desc = "Modern transport" },
                    new Category() { Name = "Fuel car", Desc = "Cars with internal combustion engines" }
                };
                return result;
            }
        }
    }
}
