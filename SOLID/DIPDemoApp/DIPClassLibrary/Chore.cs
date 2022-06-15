namespace DIPClassLibrary
{
    public class Chore
    {
        public string ChoreName { get; set; }

        public Person Owner { get; set; }

        public double HoursWorked { get; set; }

        public bool IsComplete { get; set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger logger = new Logger();
            logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            Logger logger = new Logger();
            logger.Log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is completed");
        }
    }
}