using DemoShop.Data.Models;
using System.Collections.Generic;

namespace DemoShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll { get; }
    }
}
