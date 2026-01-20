using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BrowserBuddy
{
    internal class BrowserTab
    {
        public string Url;
        public BrowserTab Next;
        public BrowserTab Previous;
        public BrowserTab(string url)
        {
            Url = url;
            Next = null;
            Previous = null;
        }
    }
}
