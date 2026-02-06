using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Reviews
{
    internal interface ILibraryOperations
    {
        void displayBooks();
        void checkOutBook(string title);
        void searchBookByTitle(String title);
    }
}
