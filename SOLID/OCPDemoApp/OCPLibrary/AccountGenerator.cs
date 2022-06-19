namespace OCPLibrary
{
    public class AccountGenerator
    {
        public Employee Create(Person person)
        {
            var result = new Employee();

            result.FirstName = person.FirstName;
            result.LastName = person.LastName;
            result.Email = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@gmail.com";

            return result;
        }
    }
}
