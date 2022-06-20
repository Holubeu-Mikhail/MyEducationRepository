using System;
using LSPLibrary.Interfaces;

namespace LSPLibrary.Models
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + rank * 4;
        }

        public void GeneratePerformanceReview()
        {
            //Simulating
            Console.WriteLine("A direct report's review");
        }
    }
}
