using System;

namespace ConsoleUI
{
    internal class PersonDataCapture
    {
        public static Person Capture()
        {
            var output = new Person();

            Console.WriteLine("Enter your first name:");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
