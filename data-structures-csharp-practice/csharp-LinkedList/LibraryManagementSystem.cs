using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    public class BookNode
    {
        public int BookId;
        public string Title;
        public string Author;
        public string Genre;
        public bool IsAvailable;


        public BookNode Next;
        public BookNode Prev;

        public BookNode(int bookId, string title, string author, string genre, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }
    }

    class LibraryDoublyLinkedList
    {
        private BookNode head;
        private BookNode tail;

   
        public void AddAtBeginning(int id, string title, string author, string genre, bool isAvailable)
        {
            BookNode newBook = new BookNode(id, title, author, genre, isAvailable);

            if (head == null)
            {
                head = tail = newBook;
                return;
            }

            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }

        public void AddAtEnd(int id, string title, string author, string genre, bool isAvailable)
        {
            BookNode newBook = new BookNode(id, title, author, genre, isAvailable);

            if (head == null)
            {
                head = tail = newBook;
                return;
            }

            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }

        public void AddAtPosition(int position, int id, string title, string author, string genre, bool isAvailable)
        {
            if (position <= 1 || head == null)
            {
                AddAtBeginning(id, title, author, genre, isAvailable);
                return;
            }

            BookNode current = head;

            for (int i = 1; i < position - 1 && current.Next != null; i++)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                AddAtEnd(id, title, author, genre, isAvailable);
                return;
            }

            BookNode newBook = new BookNode(id, title, author, genre, isAvailable);

            newBook.Next = current.Next;
            newBook.Prev = current;
            current.Next.Prev = newBook;
            current.Next = newBook;
        }

        public void RemoveByBookId(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = head;

            while (current != null && current.BookId != id)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (current == head)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
            }
            else if (current == tail)
            {
                tail = tail.Prev;
                tail.Next = null;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            }

            Console.WriteLine("Book removed successfully.");
        }

        public void SearchByTitle(string title)
        {
            BookNode current = head;
            bool found = false;

            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    PrintBook(current);
                    found = true;
                }
                current = current.Next;
            }

            if (!found)
                Console.WriteLine("No book found with this title.");
        }

        public void SearchByAuthor(string author)
        {
            BookNode current = head;
            bool found = false;

            while (current != null)
            {
                if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    PrintBook(current);
                    found = true;
                }
                current = current.Next;
            }

            if (!found)
                Console.WriteLine("No books found by this author.");
        }

        public void UpdateAvailability(int id, bool isAvailable)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.BookId == id)
                {
                    current.IsAvailable = isAvailable;
                    Console.WriteLine("Book availability updated successfully.");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = head;
            while (current != null)
            {
                PrintBook(current);
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode current = tail;
            while (current != null)
            {
                PrintBook(current);
                current = current.Prev;
            }
        }

        public void CountBooks()
        {
            int count = 0;
            BookNode current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            Console.WriteLine($"Total books in library: {count}");
        }

        private void PrintBook(BookNode book)
        {
            Console.WriteLine(
                $"{book.BookId} | {book.Title} | {book.Author} | {book.Genre} | " +
                (book.IsAvailable ? "Available" : "Not Available"));
        }
    }

    class LibraryManagementSystem
    {
        static void Main()
        {
            LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();

            library.AddAtEnd(101, "The Alchemist", "Paulo Coelho", "Fiction", true);
            library.AddAtBeginning(102, "Clean Code", "Robert C. Martin", "Programming", true);
            library.AddAtPosition(2, 103, "1984", "George Orwell", "Dystopian", false);

            Console.WriteLine(" Library Books (Forward):");
            library.DisplayForward();

            Console.WriteLine(" Library Books (Reverse):");
            library.DisplayReverse();

            Console.WriteLine("Search by Author:");
            library.SearchByAuthor("George Orwell");

            Console.WriteLine("Updating Availability:");
            library.UpdateAvailability(103, true);

            Console.WriteLine(" Removing Book ID 101:");
            library.RemoveByBookId(101);

            Console.WriteLine(" Final Library:");
            library.DisplayForward();

            library.CountBooks();
        }
    }
}
