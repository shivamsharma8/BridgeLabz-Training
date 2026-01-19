using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BookShelf
{
    internal class BookShelfMenu
    {
        public static void Display(IBookShelf shelf)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- BookShelf Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Show Books by Genre");
                Console.WriteLine("5. Show All Books");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter Book Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        shelf.AddBook(genre, name, author);
                        break;

                    case 2:
                        Console.Write("Enter Genre: ");
                        shelf.BorrowBook(Console.ReadLine(),
                            GetInput("Enter Book Name: "));
                        break;

                    case 3:
                        Console.Write("Enter Genre: ");
                        string g = Console.ReadLine();
                        Console.Write("Enter Book Name: ");
                        string bn = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string au = Console.ReadLine();
                        shelf.ReturnBook(g, bn, au);
                        break;

                    case 4:
                        Console.Write("Enter Genre: ");
                        shelf.ShowGenreBooks(Console.ReadLine());
                        break;

                    case 5:
                        shelf.ShowAllBooks();
                        break;
                }
            } while (choice != 0);
        }

        private static string GetInput(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
