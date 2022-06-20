using System;
using System.Collections.Generic;
using OCPLibrary.Interfaces;
using OCPLibrary.People;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<IApplicant>()
            {
                new Person { FirstName = "Mike", LastName = "Johnson" },
                new Manager { FirstName = "Vito", LastName = "Cruise" },
                new Executive { FirstName = "Tim", LastName = "Storm" }
            };

            var employees = new List<Employee>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountGenerator.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Email}\nIs manager: {employee.IsManager}; Is executive: {employee.IsExecutive}\n");
            }
        }
    }
}
