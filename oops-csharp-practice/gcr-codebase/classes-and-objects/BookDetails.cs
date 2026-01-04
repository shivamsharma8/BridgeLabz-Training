using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.class_and_object
{
    public class BookDetails
    {
        string title;
        string author;
        double price;
        public BookDetails(string enteredTitle, string enteredAuthor, double enteredPrice) {
            this.title = enteredTitle;
            this.author = enteredAuthor;
            this.price = enteredPrice;
        
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Details are given below");
            Console.WriteLine("Title of the book is : "+title);
            Console.WriteLine("Author of the book is : "+author);
            Console.WriteLine("Price of the book is : "+price);

        }
        static void Main(string[] args)
        {
            BookDetails book1 = new BookDetails("Last of us", "Loveesh", 300);
            book1.DisplayBookDetails();
        }
    }
}
