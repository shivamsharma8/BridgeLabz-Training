using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.ParcelTracker
{
    internal interface IParcelTracker
    {
        void AddStage(string stageName);
        void AddCheckpoint(string afterStage, string newStage);
        void TrackParcel();
        bool IsParcelLost();
    }
}
