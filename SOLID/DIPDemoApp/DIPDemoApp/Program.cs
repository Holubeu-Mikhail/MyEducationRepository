using System;
using DIPClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "Jack",
                LastName = "Jones",
                EmailAddress = "testaddress@mail.ru",
                PhoneNumber = "8029101223"
            };

            Chore chore = new Chore()
            {
                ChoreName = "Take out the trash",
                Owner = person
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
