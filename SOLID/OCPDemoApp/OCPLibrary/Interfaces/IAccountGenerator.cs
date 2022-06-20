using OCPLibrary.People;

namespace OCPLibrary.Interfaces
{
    public interface IAccountGenerator
    {
        Employee Create(IApplicant person);
    }
}