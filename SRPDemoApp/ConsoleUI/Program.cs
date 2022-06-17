using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person user = new Person();

            Console.WriteLine("Enter your first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("Wrong first name");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("Wrong last name");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1).ToLower()}{user.LastName.ToLower()}");
        }
    }
}
