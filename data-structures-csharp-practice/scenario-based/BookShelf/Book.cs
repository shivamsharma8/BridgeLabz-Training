using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BookShelf
{
    internal class Book
    {
        public string BookName { get; private set; }
        public string Author { get; private set; }

        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
        }
    }
}
