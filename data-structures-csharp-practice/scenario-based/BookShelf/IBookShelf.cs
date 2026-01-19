using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BookShelf
{
    internal interface IBookShelf
    {
        void AddBook(string genre, string bookName, string author);
        void BorrowBook(string genre, string bookName);
        void ReturnBook(string genre, string bookName, string author);
        void ShowGenreBooks(string genre);
        void ShowAllBooks();
    }
}
