using System;
using System.Collections.Generic; // Needed for List<T>

class Book
{
    // Public variables for book details
    public string Title;
    public string Author;

    // Constructor to initialize book
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    // List to store multiple books
    public List<Book> Books = new List<Book>();

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    
    // Method to display all books in the library
    public void ShowBooks()
    {
        foreach(var b in Books)
            Console.WriteLine(b.Title+" by "+b.Author);
    }
}

class Program
{
    static void Main()
    {
        // Creating book objects
        Book b1 = new Book("Book1", "Author1");
        Book b2 = new Book("Book2", "Author2");

        // Creating library object
        Library lib = new Library();

        // Adding books to the library
        lib.AddBook(b1);
        lib.AddBook(b2);

        // Displaying all books
        lib.ShowBooks();
    }
}

// Need to mention one thing more 
// Book exist outside the library, so this is aggregation.
