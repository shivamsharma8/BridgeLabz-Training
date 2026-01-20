using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.BrowserBuddy
{
    internal interface ITaskHistoryManagerOperations
    {
        void VisitPage(string url);
        void GoBack();
        void GoForward();
        void CloseTab();
        void RestoreTabs();
        void ShowHistory();

    }
}
