namespace Task2_EduInstitution
{
    internal class Program
    {
        private const string NAME = "Gomel State Technical University";
        private const InstitutionType INSTITUTION_TYPE = InstitutionType.University;
        static void Main(string[] args)
        {
            Console.WriteLine("Insert year of foundation of the educational institution:");
            string userInput = Console.ReadLine();
            int foundationYear = Int32.Parse(userInput);

            EducationalInstitution? educationalInstitution = new EducationalInstitution(name: NAME, institutionType: INSTITUTION_TYPE, foundationYear: foundationYear);

            if (educationalInstitution.FoundationYear != 0)
            {
                Console.WriteLine(educationalInstitution);

                EducationalInstitution.Minister = "Kosinau";
                Console.WriteLine(educationalInstitution);
            }

            educationalInstitution.Dispose();

            //educationalInstitution = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
        }
    }
}