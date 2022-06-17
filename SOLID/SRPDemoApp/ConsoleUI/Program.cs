using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.OutputWelcomeMessage();

            var user = PersonDataCapture.Capture();

            var isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }
            
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
