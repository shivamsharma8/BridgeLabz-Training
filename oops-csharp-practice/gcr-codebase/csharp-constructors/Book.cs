using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.constructors
{
    public class Book
    {
        string title;
        string author;
        double price;
        //default constructor
        public Book()
        {
            title = "Concepts of Physics";
            author = "HC Verma";
            price = 5000;//rupees
        }
        //parameterised constructor
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Title of the book is :"+title+", the author is "+author+" ,price of the book is "+ price);
        }
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("Book 1 details");
            book1.DisplayDetails();
            Book book2 = new Book("Diwar","Dev Malu",2000);
            Console.WriteLine("Book 2");
            book2.DisplayDetails();
        }
    }
}
