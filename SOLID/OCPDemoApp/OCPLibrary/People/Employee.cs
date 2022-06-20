using OCPLibrary.Interfaces;

namespace OCPLibrary.People
{
    public class Employee : IApplicant
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public IAccountGenerator AccountGenerator { get; set; }

        public bool IsManager { get; set; } = false;

        public bool IsExecutive { get; set; } = false;
    }
}
