using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class Vehicle
    {
        public static double RegistrationFee = 5000;
        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;

        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Updated Registration Fee: " + RegistrationFee);
        }
        public void DisplayVehicleDetails(object vehicle)
        {
            if (vehicle is Vehicle)
            {
                Console.WriteLine("Owner Name          : " + OwnerName);
                Console.WriteLine("Vehicle Type        : " + VehicleType);
                Console.WriteLine("Registration Number : " + RegistrationNumber);
                Console.WriteLine("Registration Fee    : " + RegistrationFee);
            }
            else
            {
                Console.WriteLine("Invalid vehicle object");
            }
        }
    }

    class VehicleRegistrationSystem
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Loveesh", "Car", "MH12AB1234");
            Vehicle vehicle2 = new Vehicle("Dev", "Bike", "MH14CD5678");

            vehicle1.DisplayVehicleDetails(vehicle1);
            Console.WriteLine();

            vehicle2.DisplayVehicleDetails(vehicle2);
            Console.WriteLine();

            Vehicle.UpdateRegistrationFee(7000);
            Console.WriteLine();

            vehicle1.DisplayVehicleDetails(vehicle1);

        }
    }
}
