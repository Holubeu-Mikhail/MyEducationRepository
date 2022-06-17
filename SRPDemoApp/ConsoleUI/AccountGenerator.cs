using System;

namespace ConsoleUI
{
    internal class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1).ToLower()}{user.LastName.ToLower()}");
        }
    }
}
