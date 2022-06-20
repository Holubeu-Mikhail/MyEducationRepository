namespace OCPLibrary.Interfaces
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountGenerator AccountGenerator { get; set; }
    }
}