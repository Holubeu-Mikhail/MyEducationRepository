using System;
using LSPLibrary.Interfaces;

namespace LSPLibrary.Models
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
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
