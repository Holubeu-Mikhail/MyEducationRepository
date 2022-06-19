namespace OCPLibrary
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
    }
}
