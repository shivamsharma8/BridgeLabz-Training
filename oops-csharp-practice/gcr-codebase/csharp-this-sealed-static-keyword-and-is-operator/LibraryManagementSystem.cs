using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class Book
    {
        public static string LibraryName = "Central City Library";
        public readonly string ISBN;
        public string Title;
        public string Author;
        
        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name: " + LibraryName);
        }
        public void DisplayBookDetails(object book)
        {
            if (book is Book)
            {
                Console.WriteLine("Title  : " + Title);
                Console.WriteLine("Author : " + Author);
                Console.WriteLine("ISBN   : " + ISBN);
            }
            else
            {
                Console.WriteLine("Invalid book object");
            }
        }
    }

    class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            Book.DisplayLibraryName();
            Book book1 = new Book("Clean", "Ris", "ISBN-101");
            Book book2 = new Book("Atomic", "Hitler", "ISBN-102");

            book1.DisplayBookDetails(book1);
            Console.WriteLine();

            book2.DisplayBookDetails(book2);
        }
    }
}
