using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BookShelf
{
    internal class BookShelfImpl:IBookShelf
    {
        private Dictionary<string, LinkedList<Book>> library = new Dictionary<string, LinkedList<Book>>();

        public void AddBook(string genre, string bookName, string author)
        {
            if (!library.ContainsKey(genre))
            {
                library[genre] = new LinkedList<Book>();
            }

            library[genre].AddLast(new Book(bookName, author));
            Console.WriteLine($"Book '{bookName}' added to {genre} genre.");
        }

        public void BorrowBook(string genre, string bookName)
        {
            if (!library.ContainsKey(genre) || library[genre].Count == 0)
            {
                Console.WriteLine("No books available in this genre.");
                return;
            }

            var list = library[genre];
            var node = list.First;

            while (node != null)
            {
                if (node.Value.BookName.Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    list.Remove(node);
                    Console.WriteLine($"Book '{bookName}' borrowed successfully.");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public void ReturnBook(string genre, string bookName, string author)
        {
            AddBook(genre, bookName, author);
            Console.WriteLine($"Book '{bookName}' returned to library.");
        }

        public void ShowGenreBooks(string genre)
        {
            if (!library.ContainsKey(genre) || library[genre].Count == 0)
            {
                Console.WriteLine("No books found for this genre.");
                return;
            }

            Console.WriteLine($"\nBooks in {genre} genre:");
            foreach (var book in library[genre])
            {
                Console.WriteLine($"{book.BookName} - {book.Author}");
            }
        }

        public void ShowAllBooks()
        {
            if (library.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Console.WriteLine("\nComplete Library Catalog:");
            foreach (var genre in library.Keys)
            {
                Console.WriteLine($"\nGenre: {genre}");
                foreach (var book in library[genre])
                {
                    Console.WriteLine($"{book.BookName} - {book.Author}");
                }
            }
        }
    }
}
