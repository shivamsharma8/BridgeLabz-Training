using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.AddressBookSystem
{
    internal class AddressBookManager
    {
        //UC5
        private AddressBook[] books = new AddressBook[10];
        private int count = 0;

        public void AddBook(string name)
        {
            books[count++] = new AddressBook(name);
            Console.WriteLine("AddressBook Created");
        }

        public AddressBook GetBook(string name)
        {
            for(int i = 0; i  < count; i++)
            {
                if (books[i].BookName.Equals(name)) return books[i];
            }
            return null;
        }
    }
}
