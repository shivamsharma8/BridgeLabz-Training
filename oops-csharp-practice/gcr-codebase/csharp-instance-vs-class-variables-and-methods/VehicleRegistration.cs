using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.instance
{
    public class Vehicle
    {
        private static float registrationFee = 5000;
        private string ownerName;
        private string vehicleType;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        internal void DisplayVehicleDetails()
        {
            Console.WriteLine("Here are the vehicle details: ");
            Console.WriteLine("Owner Name: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
            Console.WriteLine("Registration Fee: " + registrationFee);
        }

        internal static void UpdateRegistrationFee(float updatedRegistrationFee)
        {
            registrationFee = updatedRegistrationFee;
            Console.WriteLine("Registration Fees Updated");
        }
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Loveesh", "Bike");
            Vehicle vehicle2 = new Vehicle("Dev Malu", "Car");

            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();

            Vehicle.UpdateRegistrationFee(10000);

            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
        }
    }

}
