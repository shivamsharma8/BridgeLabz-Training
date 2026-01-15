using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.AddressBookSystem
{
    internal class ContactPerson
    {
        public string FirstName;
        public string LastName;
        public string City;
        public string State;
        public string Zip;
        public string Phone;
        public string Email;


        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + City + " " + State + " " + Zip + " " + Phone + " " + Email);
        }


    }
}
