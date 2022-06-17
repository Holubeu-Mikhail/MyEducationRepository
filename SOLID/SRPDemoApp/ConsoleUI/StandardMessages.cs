using System;

namespace ConsoleUI
{
    internal class StandardMessages
    {
        public static void OutputWelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"Wrong { fieldName }");
        }
    }
}
