using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.access_modifiers
{
    public class BookLibrarySystem
    {
        static void Main(string[] args)
        {
            EBook eBook1 = new EBook("Robert Downey Jr.", "Marvel", "937-3474834");
            eBook1.DisplayDetails();
            Console.WriteLine("ISBN from Main : "+ eBook1.iSBN);
        }
    }
    public class Book
    {
        public string iSBN;
        protected string title;
        private string author;

        public Book(string title, string author, string iSBN)
        {
            this.title = title;
            this.author = author;
            this.iSBN = iSBN;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string authorName)
        {
            author = authorName;
        }

    }
    public class EBook : Book
    {
        public EBook(string title, string author, string iSBN) : base(title, author, iSBN) { }

        public void DisplayDetails()
        {
            Console.WriteLine("Displaying the details");
            Console.WriteLine("ISBN : "+iSBN);
            Console.WriteLine("Title : "+title);
            Console.WriteLine("Author : "+ GetAuthor());
        }
    }
}
