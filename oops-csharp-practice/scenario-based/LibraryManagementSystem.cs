using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    internal class LibraryManagementSystem
    {
        static string[] titles = { "The Alchemist",
    "Clean Code",
    "Atomic Habits",
    "C Sharp Programming",
    "Data Structures",
    "Design Patterns",
    "Refactoring",
    "Introduction to Algorithms",
    "Operating System Concepts",
    "Computer Networks",
    "Effective Java",
    "Head First Design Patterns",
    "The Pragmatic Programmer",
    "You Don't Know JS",
    "Python Crash Course"};
        static string[] authors = {"Paulo Coelho",
    "Robert C Martin",
    "James Clear",
    "Microsoft",
    "Mark Allen Weiss",
    "Erich Gamma",
    "Martin Fowler",
    "Thomas H Cormen",
    "Abraham Silberschatz",
    "Andrew S Tanenbaum",
    "Joshua Bloch",
    "Eric Freeman",
    "Andrew Hunt",
    "Kyle Simpson",
    "Eric Matthes" };
        static bool[] isAvailable = {true,   // The Alchemist
    false,  // Clean Code
    true,   // Atomic Habits
    true,   // C Sharp Programming
    false,  // Data Structures
    true,   // Design Patterns
    true,   // Refactoring
    true,   // Introduction to Algorithms
    false,  // Operating System Concepts
    true,   // Computer Networks
    true,   // Effective Java
    false,  // Head First Design Patterns
    true,   // The Pragmatic Programmer
    true,   // You Don't Know JS
    true    // Python Crash Course
    };
        static void DisplayBooks()
        {
            Console.WriteLine("Available books");
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + (titles[i]) + " | " + (authors[i]) + " | " + (isAvailable[i] ? "Available" : "Checked out"));

            }
        }
        static void SearchBooks(string search)
        {
            bool found = false;
            Console.WriteLine("Search Results");
            for (int i = 0; i < titles.Length; i++)
            {
                if (titles[i].ToLower().Contains(search.ToLower()))
                {

                    Console.WriteLine((i + 1) + "." + (titles[i]) + " | " + (authors[i]) + " | " + (isAvailable[i] ? "Available" : "Checked out"));
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("select books in record");
            }
        }
        static void CheckoutBook(int index)
        {
            if (index < 0 || index >= titles.Length)
            {
                Console.WriteLine("Invalid book selection");
                return;
            }
            if (isAvailable[index])
            {
                isAvailable[index] = false;
                Console.WriteLine("The book has been checked out");
            }
            else
            {
                Console.WriteLine("The book is already checked out");
            }
        }
        static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("       Library Management System          ");
                Console.WriteLine("1. Display All Books");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Checkout a Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayBooks();
                        break;

                    case "2":
                        string search = Console.ReadLine();
                        SearchBooks(search);
                        break;

                    case "3":
                        DisplayBooks();
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        CheckoutBook(index);
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting Library System ");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
