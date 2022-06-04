using DemoShop.Data.Models;

namespace DemoShop.Data.Interfaces
{
    public interface IOrderRepository
    {
        public void Create(Order order);
    }
}
