using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BrowserBuddy
{
    internal class BrowserBuddyMain
    {
        static void Main(string[] args)
        {
            ITaskHistoryManagerOperations browser = new BrowserFunctionImpl();
            BrowserFunctionsMenu.DisplayMenu(browser);
        }
    }
}
