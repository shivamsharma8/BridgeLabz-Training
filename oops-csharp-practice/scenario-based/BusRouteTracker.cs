using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.scenario_based
{
    public class BusRouteTracker
    {
        static void Main(string[] args)
        {
            int distanceAfterStop = 5;//distance in km
            int totalDistanceTravelled = 0;
            bool isPassengerOnBus = true;
            int stopNumber = 0;
            Console.WriteLine("Bus travel journey started");
            while (isPassengerOnBus)
            {
                stopNumber++;
                totalDistanceTravelled += distanceAfterStop;
                Console.WriteLine("Bus reached a new stop, stop number is: "+stopNumber);
                Console.WriteLine("Total distance travelled so far is " +totalDistanceTravelled+" km.");
                Console.WriteLine("Do you want to get off the bus: Enter(yes/no) :");
                string riderChoice = Console.ReadLine().ToLower();
                if( riderChoice == "yes")
                {
                    isPassengerOnBus=false;
                }
            }
            Console.WriteLine("Journey Ended");
            Console.WriteLine("Total distance travelled overall is : "+totalDistanceTravelled+" km.");
        }
    }
}
