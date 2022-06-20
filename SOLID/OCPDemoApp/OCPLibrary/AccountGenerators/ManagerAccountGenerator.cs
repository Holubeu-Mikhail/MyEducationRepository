using OCPLibrary.Interfaces;
using OCPLibrary.People;

namespace OCPLibrary.AccountGenerators
{
    public class ManagerAccountGenerator : IAccountGenerator
    {
        public Employee Create(IApplicant person)
        {
            var result = new Employee();

            result.FirstName = person.FirstName;
            result.LastName = person.LastName;
            result.Email = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@gmailcorp.com";

            result.IsManager = true;

            return result;
        }
    }
}
