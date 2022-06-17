using System;

namespace ConsoleUI
{
    internal class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
