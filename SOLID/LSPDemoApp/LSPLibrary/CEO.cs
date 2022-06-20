using System;

namespace LSPLibrary
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public override void AssignManager(Manager manager)
        {
            throw new InvalidOperationException("The CEO has no manager.");
        }

        public void GeneratePerformanceReview()
        {
            //Simulating
            Console.WriteLine("A direct report's review");
        }

        public void Fire(Employee employee = null)
        {
            //Simulating
            Console.WriteLine("Employee is fired.");
        }
    }
}
