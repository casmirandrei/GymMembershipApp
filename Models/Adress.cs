using System;

namespace Cv9Gym_ManagementApp
{
    public class Address
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }


        public Address(string streetName, string streetNumber)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public Address()
        {
        }

        public void Adress()
        {
            Console.WriteLine(StreetName + StreetNumber);
        }

        
    }


}
