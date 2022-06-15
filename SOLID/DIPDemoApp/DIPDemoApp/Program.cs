using DIPClassLibrary.Interfaces;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = Factory.CreatePerson();

            person.FirstName = "Jack";
            person.LastName = "Jones";
            person.EmailAddress = "testaddress@mail.ru";
            person.PhoneNumber = "8029101223";

            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = person;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
