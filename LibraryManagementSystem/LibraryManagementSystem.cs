using System;
using System.Collections.Generic;
using System.Text;


//3.Library Management System – Book Search and Checkout
//Scenario: You’re designing a system for a small library to manage books and track checkouts.
//Problem Requirements:
//● Store book details (title, author, status) in a Array.
//● Allow searching by partial title using String operations.
//● Store book data in an Array.
//● Use methods for searching, displaying, and updating book status (checked out or
//available).
namespace Training.Reviews
{
    internal class LibraryManagementSystem
    {
        static void Main(string[] args)
        {


            Library library = new Library(3);
            library.addBook(new Book("xyz" ,"C-Sharp"));
            library.addBook(new Book("abc", "Java"));
            library.addBook(new Book("lmn", "Python"));

            library.displayBook();

            library.checkOutBook("Python");
            library.checkOutBook("Python");
            library.searchBookByTitle("a");
        }
       

    }
}
