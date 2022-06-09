using System;
using MongoDbDemo.Models;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MongoDbCRUD("AddressBook");

            //var person1 = new Person()
            //{
            //    FirstName = "Mike",
            //    LastName = "Johnson",
            //    Address = new Address()
            //    {
            //        City = "Minsk",
            //        Street = "Sovetskaya",
            //        ZipCode = "191032"
            //    }
            //};

            //var person2 = new Person()
            //{
            //    FirstName = "Vito",
            //    LastName = "Heisenberg",
            //    Address = new Address()
            //    {
            //        City = "New-York",
            //        Street = "Wall",
            //        ZipCode = "111002"
            //    }
            //};

            //var person3 = new Person()
            //{
            //    FirstName = "Max",
            //};

            //db.Insert("People", person1);
            //db.Insert("People", person2);
            //db.Insert("People", person3);

            //var person4 = new Person()
            //{
            //    FirstName = "Mikhail",
            //    LastName = "Valuev",
            //    DateOfBirth = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Utc)
            //};

            //db.Upsert("People", person4.Id, person4);

            //var recs = db.GetAll<Name>("People");

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{ rec.FirstName } { rec.LastName }");
            //}

            var rec = db.GetById<Person>("People", Guid.Empty);

            Console.WriteLine($"{ rec.FirstName } { rec.LastName }");

            Console.ReadLine();
        }
    }
}