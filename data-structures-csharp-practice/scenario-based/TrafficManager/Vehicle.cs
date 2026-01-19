using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.TrafficManager
{
    internal class Vehicle
    {
        public string VehicleNumber;
        public Vehicle Next;

        public Vehicle(string number)
        {
            VehicleNumber = number;
            Next = null;
        }
    }
}
