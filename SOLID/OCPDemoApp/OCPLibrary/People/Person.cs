﻿using OCPLibrary.AccountGenerators;
using OCPLibrary.Interfaces;

namespace OCPLibrary.People
{
    public class Person : IApplicant
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IAccountGenerator AccountGenerator { get; set; } = new AccountGenerator();
    }
}
