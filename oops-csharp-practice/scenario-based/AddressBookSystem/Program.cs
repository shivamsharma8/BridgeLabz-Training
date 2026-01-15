using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookManager manager = new AddressBookManager();

            while (true)
            {
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display Contacts");
                Console.WriteLine("6. Search by City/State");
                Console.WriteLine("7. Count by City/State");
                Console.WriteLine("8. Sort by Name");
                Console.WriteLine("9. Sort by City");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                Console.WriteLine("AddressBook Name: ");
                string bookName = Console.ReadLine();

                if(choice == 1)
                {
                    manager.AddBook(bookName);
                        continue;
                    
                }
                AddressBook book = manager.GetBook(bookName);
                
                if(book == null)
                {
                    Console.WriteLine("Address Book not found");
                    continue;
                }

                switch (choice)
                {
                    case 2:

                        ContactPerson p = new ContactPerson();
                        Console.Write("First Name: "); p.FirstName = Console.ReadLine();
                        Console.Write("Last Name: "); p.LastName = Console.ReadLine();
                        Console.Write("City: "); p.City = Console.ReadLine();
                        Console.Write("State: "); p.State = Console.ReadLine();
                        Console.Write("Zip: "); p.Zip = Console.ReadLine();
                        Console.Write("Phone: "); p.Phone = Console.ReadLine();
                        Console.Write("Email: "); p.Email = Console.ReadLine();
                        book.AddContact(p);

                        break;

                    case 3:

                        Console.WriteLine("Enter first name: ");
                        string fn = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        string ln = Console.ReadLine();
                        book.EditContact(fn, ln);

                        break;


                    case 4:

                        Console.WriteLine("Enter first name: ");
                        fn = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        ln = Console.ReadLine();
                        book.DeleteContact(fn, ln);

                        break;

                    case 5:

                        book.DisplayAllContacts();

                        break;


                    case 6:

                        Console.Write("City or State: ");
                        book.SearchByCityOrState(Console.ReadLine());

                        break;

                    case 7:

                        Console.Write("City or State: ");
                        string value = Console.ReadLine();
                        Console.WriteLine("Count: " + book.CountByCityOrState(value));

                        break;

                    case 8:

                        book.SortByName();
                        book.DisplayAllContacts();

                        break;

                    case 9:

                        book.SortByCity();
                        book.DisplayAllContacts();

                        break;
                }
            }
        }    
    }
}
