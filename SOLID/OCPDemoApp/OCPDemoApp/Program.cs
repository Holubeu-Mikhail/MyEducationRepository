using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<Person>()
            {
                new Person { FirstName = "Mike", LastName = "Johnson" },
                new Person { FirstName = "Vito", LastName = "Cruise" },
                new Person { FirstName = "Tim", LastName = "Storm" }
            };

            var employees = new List<Employee>();
            var accountGenerator = new AccountGenerator();

            foreach (var person in applicants)
            {
                employees.Add(accountGenerator.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Email}");
            }
        }
    }
}
