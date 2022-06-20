using OCPLibrary.Interfaces;
using OCPLibrary.People;
using System;

namespace OCPLibrary.AccountGenerators
{
    public class AccountGenerator : IAccountGenerator
    {
        public Employee Create(IApplicant person)
        {
            var result = new Employee();

            result.FirstName = person.FirstName;
            result.LastName = person.LastName;
            result.Email = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@gmail.com";

            return result;
        }
    }
}
