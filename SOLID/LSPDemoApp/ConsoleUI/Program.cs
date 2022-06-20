using System;
using LSPLibrary.Interfaces;
using LSPLibrary.Models;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new CEO();

            manager.FirstName = "Joe";
            manager.LastName = "Black";
            manager.CalculatePerHourRate(4);

            IManaged employee = new Manager();

            employee.FirstName = "Mike";
            employee.LastName = "Vendor";
            employee.AssignManager(manager);
            employee.CalculatePerHourRate(2);

            Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour.");

            Console.ReadLine();
        }
    }
}