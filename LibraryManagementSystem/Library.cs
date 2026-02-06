using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Reviews
{
    internal class Library : ILibraryOperations
    {
        private Book[] books;
        private int count;


        public Library(int size)
        {
            books = new Book[size];
            count = 0;
        }

        public void addBook(Book book) { 
        
            if(count < books.Length)
            {
                books[count++] = book;
            }


        }

        public void displayBook()
        {
            Console.WriteLine("The Books are: ");

            for (int i = 0; i < books.Length; i++) {
                Console.WriteLine(
                    "Title: " + books[i].getTitle() 
                    + ", Author" + books[i].getAuthor()
                    + ", Status: " + books[i].getIsAvailable());
            }
        }

        public void checkOutBook(string title)
        {
            //Console.WriteLine(title);
            for(int i = 0; i < count; i++)
            {
                if(books[i].getTitle() == title)
                {
                    if (books[i].getIsAvailable())
                    {
                        Console.WriteLine("The Book is available and issued");
                        books[i].setIsAvailable(false);
                    }
                    else
                    {
                        Console.WriteLine("The Book You Want is already issued and not available");
                    }
                }
            }
        }


        public void searchBookByTitle(String title)
        {
            Console.WriteLine("\nSearch Results:");
            for (int i = 0; i < count; i++)
            {
                if (books[i].getTitle().ToLower().Contains(title.ToLower()))
                {
                    Console.WriteLine(books[i].getTitle() + " by " + books[i].getAuthor());
                }
            }
        }


        void ILibraryOperations.displayBooks()
        {
            throw new NotImplementedException();
        }
    }
}
