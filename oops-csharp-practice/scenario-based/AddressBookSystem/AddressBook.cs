using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.AddressBookSystem
{
    internal class AddressBook
    {
        public string BookName;
        private ContactPerson[] contacts = new ContactPerson[100];
        private int count = 0;

        public AddressBook(string name)
        {
            BookName = name;
        }

        //UC2
        public void AddContact(ContactPerson p)
        {
            for(int i = 0; i < count; i++)
            {
                //UC6
                if (contacts[i].FirstName.Equals(p.FirstName) && contacts[i].LastName.Equals(p.LastName))
                {
                    Console.WriteLine("Duplicate Contacts are not allowed");
                    return;
                }

            }
            contacts[count++] = p;
            Console.WriteLine("Contact Added");
        }


        //UC3
        public void EditContact(string fn, string ln)
        {
            for(int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(fn) && contacts[i].LastName.Equals(ln))
                {
                    Console.WriteLine("Contact Found. Enter new details:");
                    Console.Write("City: ");
                    contacts[i].City = Console.ReadLine();
                    Console.Write("State: ");
                    contacts[i].State = Console.ReadLine();
                    Console.Write("Zip: ");
                    contacts[i].Zip = Console.ReadLine();
                    Console.Write("Phone: ");
                    contacts[i].Phone = Console.ReadLine();
                    Console.Write("Email: ");
                    contacts[i].Email = Console.ReadLine();
                    Console.WriteLine("Contact Updated");
                    return;
                }
                else { 
                    Console.WriteLine("Contact Not Found");
                }
            }


        }

        //UC4
        public void DeleteContact(string fn, string ln)
        {
            for(int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(fn) && contacts[i].LastName.Equals(ln))
                {
                    //shift elements to left
                    for(int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    contacts[count - 1] = null;
                    count--;
                    Console.WriteLine("Contact Deleted");
                    return;
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("Contacts in Address Book: " + BookName);
            for(int i = 0; i < count; i++)
            {
                contacts[i].Display();
            }

        }


        //UC7 and UC8
        public void SearchByCityOrState(string value)
        {
            Console.WriteLine("Contacts in " + value + " are: ");
            for(int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(value) || contacts[i].State.Equals(value))
                {
                    contacts[i].Display();
                }
            }
        }


        //UC9
        public int CountByCityOrState(string value)
        {
            int c = 0;

            for(int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(value) || contacts[i].State.Equals(value))
                {
                    c++;
                }
            }
            

            return c;
        }


        //UC10
        public void SortByName()
        {
            for(int i = 0; i < count-1; i++)
            {
                for(int j = i+1; j < count; j++)
                {
                    if (string.Compare(contacts[i].FirstName + " " + contacts[i].LastName, contacts[j].FirstName + " " + contacts[j].LastName) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }

            
        }


        //UC11
        public void SortByCity()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(contacts[i].City, contacts[j].City) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        private void Swap(int i, int j)
        {
            ContactPerson temp = contacts[i];
            contacts[i] = contacts[j];
            contacts[j] = temp;
        }
    }
}
 