using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.ParcelTracker
{
    internal class ParcelStage
    {
        public string stageName;
        public ParcelStage Next;
        public ParcelStage(string stageName) 
        {
            this.stageName = stageName;
            Next = null;
        }
        
    }
}
