using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class UnitConvertorKMtoMiles
    {
        public double ConvertKilometersToMiles(double distanceInKilometers)
        {
            return distanceInKilometers * 0.621371;
        }

        public double ConvertMilesToKilometers(double distanceInMiles)
        {
            return distanceInMiles * 1.60934;
        }

        public double ConvertMetersToFeet(double distanceInMeters)
        {
            return distanceInMeters * 3.28084;
        }

        public double ConvertFeetToMeters(double distanceInFeet)
        {
            return distanceInFeet * 0.3048;
        }

        static void Main(string[] args)
        {
            UnitConvertorKMtoMiles converter = new UnitConvertorKMtoMiles();

            Console.Write("Enter distance in kilometers: ");
            double inputKilometers = double.Parse(Console.ReadLine());
            double resultInMiles = converter.ConvertKilometersToMiles(inputKilometers);
            Console.WriteLine(inputKilometers + " Kilometers is equal to " + resultInMiles + " Miles");

            Console.Write("Enter distance in meters: ");
            double inputMeters = double.Parse(Console.ReadLine());
            double resultInFeet = converter.ConvertMetersToFeet(inputMeters);
            Console.WriteLine(inputMeters + " Meters is equal to " + resultInFeet + " Feet");
        }
    }
}
