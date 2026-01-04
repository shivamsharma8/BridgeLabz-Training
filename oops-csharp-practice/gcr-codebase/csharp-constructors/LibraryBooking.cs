using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.constructors
{
    public class LibraryBooking
    {
        public string title { get; set; }
        public string author {  get; set; }
        public double price {  get; set; }
        public bool isAvailable {  get; private set; }
        public LibraryBooking(string title, string author, double price, bool isAvailable) {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isAvailable = isAvailable;
            
        }

        public void BorrowBook() {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("You have borrowed the book successfully "+ title);
            }
            else
            {
                Console.WriteLine("sorry "+title+" is not available");
            }
        }
        static void Main(string[] args) { 
            LibraryBooking Book1 = new LibraryBooking("James","Dev",200,true);
            Book1.BorrowBook();
            Book1.BorrowBook();
        }

    }
}
