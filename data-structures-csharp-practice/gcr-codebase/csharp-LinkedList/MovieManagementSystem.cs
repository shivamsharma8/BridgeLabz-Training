using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    public class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;

        public MovieNode Next;
        public MovieNode Prev;

        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    // Doubly Linked List
    class MovieDoublyLinkedList
    {
        private MovieNode head;
        private MovieNode tail;

        // Add at beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        // Add at specific position
        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            MovieNode temporaryTraversal = head;
            for (int i = 1; i < position - 1 && temporaryTraversal != null; i++)
            {
                temporaryTraversal = temporaryTraversal.Next;
            }

            if (temporaryTraversal == null || temporaryTraversal.Next == null)
            {
                AddAtEnd(title, director, year, rating);
                return;
            }

            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = temporaryTraversal.Next;
            newNode.Prev = temporaryTraversal;
            temporaryTraversal.Next.Prev = newNode;
            temporaryTraversal.Next = newNode;
        }

        // Remove by movie title
        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("Movie list is empty");
                return;
            }

            MovieNode temporaryTraversal = head;

            while (temporaryTraversal != null && temporaryTraversal.Title != title)
            {
                temporaryTraversal = temporaryTraversal.Next;
            }

            if (temporaryTraversal == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            if (temporaryTraversal == head)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
            }
            else if (temporaryTraversal == tail)
            {
                tail = tail.Prev;
                tail.Next = null;
            }
            else
            {
                temporaryTraversal.Prev.Next = temporaryTraversal.Next;
                temporaryTraversal.Next.Prev = temporaryTraversal.Prev;
            }

            Console.WriteLine("Movie removed successfully");
        }

        // Search by director
        public void SearchByDirector(string director)
        {
            MovieNode temporaryTraversal = head;
            bool found = false;

            while (temporaryTraversal != null)
            {
                if (temporaryTraversal.Director == director)
                {
                    DisplayMovie(temporaryTraversal);
                    found = true;
                }
                temporaryTraversal= temporaryTraversal.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director");
        }

        // Search by rating
        public void SearchByRating(double rating)
        {
            MovieNode temporaryTraversal = head;
            bool found = false;

            while (temporaryTraversal != null)
            {
                if (temporaryTraversal.Rating == rating)
                {
                    DisplayMovie(temporaryTraversal);
                    found = true;
                }
                temporaryTraversal = temporaryTraversal.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating");
        }

        // Update rating by title
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temporaryTraversal = head;

            while (temporaryTraversal != null)
            {
                if (temporaryTraversal.Title == title)
                {
                    temporaryTraversal.Rating = newRating;
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                temporaryTraversal = temporaryTraversal.Next;
            }

            Console.WriteLine("Movie not found");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies to display");
                return;
            }

            MovieNode temporaryTraversal = head;
            while (temporaryTraversal != null)
            {
                DisplayMovie(temporaryTraversal);
                temporaryTraversal = temporaryTraversal.Next;
            }
        }

        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movies to display");
                return;
            }

            MovieNode temporaryTraversal = tail;
            while (temporaryTraversal != null)
            {
                DisplayMovie(temporaryTraversal);
                temporaryTraversal = temporaryTraversal.Prev;
            }
        }

        private void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine(
                $"{movie.Title} | {movie.Director} | {movie.Year} | Rating: {movie.Rating}");
        }
    }

    class MovieManagementSystem
    {
        static void Main()
        {
            MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

            movies.AddAtEnd("Inception", "Christopher Nolan", 2010, 9.0);
            movies.AddAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
            movies.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);

            Console.WriteLine("\nAll Movies (Forward):");
            movies.DisplayForward();

            Console.WriteLine("\nAll Movies (Reverse):");
            movies.DisplayReverse();

            Console.WriteLine("\nSearch by Director:");
            movies.SearchByDirector("Christopher Nolan");

            Console.WriteLine("\nUpdating Rating:");
            movies.UpdateRating("Avatar", 8.2);

            Console.WriteLine("\nRemoving Movie:");
            movies.RemoveByTitle("Inception");

            Console.WriteLine("\nFinal Movie List:");
            movies.DisplayForward();
        }
    }
}

