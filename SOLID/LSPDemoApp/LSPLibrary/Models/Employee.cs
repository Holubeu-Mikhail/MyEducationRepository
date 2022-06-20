using LSPLibrary.Interfaces;

namespace LSPLibrary.Models
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            //Simulating
            Manager = manager;
        }
    }
}
