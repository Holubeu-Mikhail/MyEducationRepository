namespace DemoShop.Data.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public Car Car { get; set; }

        public uint Price { get; set; }

        public string CartId { get; set; }
    }
}
