using System;
using LSPLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();

            manager.FirstName = "Joe";
            manager.LastName = "Black";
            manager.CalculatePerHourRate(4);

            var employee = new Employee();

            employee.FirstName = "Mike";
            employee.LastName = "Mike";
            employee.AssignManager(manager);
            employee.CalculatePerHourRate(2);

            Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour.");

            Console.ReadLine();
        }
    }
}