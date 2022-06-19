using System;

namespace OCPLibrary
{
    public class AccountGenerator
    {
        public Employee Create(Person person)
        {
            var result = new Employee();

            result.FirstName = person.FirstName;
            result.LastName = person.LastName;
            result.Email = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@gmail.com";

            switch (person.TypeOfEmployee)
            {
                case EmployeeType.Staff:
                    break;
                case EmployeeType.Manager:
                    result.IsManager = true;
                    break;
                case EmployeeType.Executive:
                    result.IsExecutive = true;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
