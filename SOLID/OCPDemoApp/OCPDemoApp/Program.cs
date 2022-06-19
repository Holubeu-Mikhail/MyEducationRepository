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
                new Person { FirstName = "Vito", LastName = "Cruise", TypeOfEmployee = EmployeeType.Manager },
                new Person { FirstName = "Tim", LastName = "Storm", TypeOfEmployee = EmployeeType.Executive }
            };

            var employees = new List<Employee>();
            var accountGenerator = new AccountGenerator();

            foreach (var person in applicants)
            {
                employees.Add(accountGenerator.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Email}\nIs manager: {employee.IsManager}; Is executive: {employee.IsExecutive}\n");
            }
        }
    }
}
