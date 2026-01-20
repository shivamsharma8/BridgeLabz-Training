using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.ParcelTracker
{
    internal class ParcelTrackerMain
    {
        static void Main(string[] args)
        {
            RunParcelTracker();
        }

        static void RunParcelTracker()
        {
            IParcelTracker tracker = new ParcelTrackerImpl();
            //Inital Tracking of parcel
            InitializeDefaultStages(tracker);
            tracker.TrackParcel();
            //Custom Checkpoint addition between stages
            Console.WriteLine("Adding custom checkpoint.");
            tracker.AddCheckpoint("Shipped", "Custom Security Check");
            tracker.TrackParcel();
            //Check for lost parcel
            Console.WriteLine("Checking lost parcel case...");
            IParcelTracker lostParcel = new ParcelTrackerImpl();
            lostParcel.TrackParcel();
        }
        //Initial addition of stages in parcel
        static void InitializeDefaultStages(IParcelTracker tracker)
        {
            tracker.AddStage("Packed");
            tracker.AddStage("Shipped");
            tracker.AddStage("In Transit");
            tracker.AddStage("Delivered");
        }
    }
}
