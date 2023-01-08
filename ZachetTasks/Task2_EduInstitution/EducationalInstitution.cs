namespace Task2_EduInstitution
{
    internal class EducationalInstitution : IDisposable
    {
        public static string Minister;

        private InstitutionType _institutionType;
        private int _foundationYear;
        private string _name;

        static EducationalInstitution()
        {
            Minister = "Zhuraukou";
        }

        public EducationalInstitution() : this(InstitutionType.Undefined, DateTime.Now.Year, "Name Undefined") { }

        public EducationalInstitution(InstitutionType institutionType, int foundationYear, string name)
        {
            InstitutionType = institutionType;
            FoundationYear = foundationYear;
            Name = name;
        }

        public InstitutionType InstitutionType
        {
            get
            {
                return _institutionType;
            }
            set
            {
                _institutionType = value;
            }
        }
        public int FoundationYear
        {
            get
            {
                return _foundationYear;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    _foundationYear = value;
                }
                else
                {
                    Console.WriteLine("Year cannot be less than 1900 and more than current year");
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return $"{InstitutionType} called {Name} was founded in {FoundationYear}\nCurrent Minister of Education is {Minister}\n";
        }

        public void Dispose()
        {
            Console.WriteLine("Object was disposed");
        }

        ~EducationalInstitution()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}
