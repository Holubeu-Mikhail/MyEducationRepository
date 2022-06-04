using System.Collections.Generic;
using System.Linq;
using DemoShop.Data.Models;

namespace DemoShop.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> category;

        public static void Initialize(AppDbContext context)
        {
            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(x => x.Value));
            }

            if (!context.Car.Any())
            {
                context.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Fast and silent",
                        LongDesc = "Good sedan for casual life with electric engine",
                        Image = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Electric car"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow and silent",
                        LongDesc = "Good sedan for casual life with default engine",
                        Image = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Fuel car"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Fast and stylish",
                        LongDesc = "Good sedan for fast city driving",
                        Image = "/img/bmwm3.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Fuel car"]
                    },
                    new Car
                    {
                        Name = "Mercedes S class",
                        ShortDesc = "Comfortable and luxury",
                        LongDesc = "Good luxury sedan with electric engine for businessmen",
                        Image = "/img/w140.jpg",
                        Price = 85000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Fuel car"]
                    },
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Fast and silent",
                        LongDesc = "Good sedan for casual life with electric engine",
                        Image = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Fuel car"]
                    }
                    );
            }

            context.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new List<Category>
                    {
                        new Category() { Name = "Electric car", Desc = "Modern transport" },
                        new Category() { Name = "Fuel car", Desc = "Cars with internal combustion engines" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (var el in list)
                    {
                        category.Add(el.Name, el);
                    }
                }

                return category;
            }
        }
    }
}
