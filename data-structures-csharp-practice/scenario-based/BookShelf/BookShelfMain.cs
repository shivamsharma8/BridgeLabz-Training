using BridgeLabz_Training.OOPS.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BookShelf
{
    internal class BookShelfMain
    {

        static void Main(string[] args)
        {
            IBookShelf shelf = new BookShelfImpl();
            BookShelfMenu.Display(shelf);
        }
    }
}
