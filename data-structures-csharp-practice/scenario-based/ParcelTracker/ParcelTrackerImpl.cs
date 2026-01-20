using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.ParcelTracker
{
    internal class ParcelTrackerImpl:IParcelTracker
    {
        private ParcelStage head;
        public ParcelTrackerImpl()
        {
            head = null;
        }
        //Packed->Shipped->In Transit
        public void AddStage(string stageName)
        {
            ParcelStage newStage = new ParcelStage(stageName);
            if (head == null)
            {
                head = newStage;
                return;
            }
            ParcelStage temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStage;
        }
        //stageBefore->checkpoint->stageAfter
        public void AddCheckpoint(string afterStage, string newStage)
        {
            ParcelStage temp = head;
            while(temp!=null && temp.stageName != afterStage)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine($"Stage '{afterStage}' not found. Cannot add '{newStage}'.");
                return;
            }
            ParcelStage checkpoint = new ParcelStage(newStage);
            checkpoint.Next = temp.Next;
            temp.Next = checkpoint;
        }
        //Tarck Parcel
        public void TrackParcel() {
            if (head == null)
            {
                Console.WriteLine("Parcel is lost or no tracking data available (null pointer).");
                return;
            }

            ParcelStage temp = head;
            Console.Write("Parcel Journey: ");

            while (temp != null)
            {
                Console.Write(temp.stageName);

                if (temp.Next != null)
                    Console.Write(" ");

                temp = temp.Next;
            }

            Console.WriteLine(" null");
        }

        public bool IsParcelLost() { return head == null; }
    }
}
