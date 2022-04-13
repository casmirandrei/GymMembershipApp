namespace Cv9Gym_ManagementApp
{
    public class Person
    {
        public string Nr { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Address Address { get; set; }
        public string Subscription { get; set; }

        public Person()
        {
        }

        public Person(string nr, string lastName, string firstName)
        {
            Nr = nr;
            LastName = lastName;
            FirstName = firstName;

        }
    }
}
