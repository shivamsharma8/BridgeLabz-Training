using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class UnitCOnvertorFarenheitToCelcius
    {
        public double ConvertFahrenheitToCelsius(double temperatureInFahrenheit)
        {
            return (temperatureInFahrenheit - 32) * 5 / 9;
        }

        public double ConvertCelsiusToFahrenheit(double temperatureInCelsius)
        {
            return (temperatureInCelsius * 9 / 5) + 32;
        }

        
        public double ConvertPoundsToKilograms(double weightInPounds)
        {
            return weightInPounds * 0.453592;
        }

        public double ConvertKilogramsToPounds(double weightInKilograms)
        {
            return weightInKilograms * 2.20462;
        }

        
        public double ConvertGallonsToLiters(double volumeInGallons)
        {
            return volumeInGallons * 3.78541;
        }

        public double ConvertLitersToGallons(double volumeInLiters)
        {
            return volumeInLiters * 0.264172;
        }

        static void Main(string[] args)
        {
            UnitCOnvertorFarenheitToCelcius utility = new UnitCOnvertorFarenheitToCelcius();

            // Temperature Example
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheitInput = double.Parse(Console.ReadLine());
            double celsiusResult = utility.ConvertFahrenheitToCelsius(fahrenheitInput);
            Console.WriteLine(fahrenheitInput + "°F is " + celsiusResult + "°C");

            // Weight Example
            Console.Write("Enter weight in kilograms: ");
            double kgInput = double.Parse(Console.ReadLine());
            double poundsResult = utility.ConvertKilogramsToPounds(kgInput);
            Console.WriteLine(kgInput + " kg is " + poundsResult + " lbs");

            // Volume Example
            Console.Write("Enter volume in gallons: ");
            double gallonsInput = double.Parse(Console.ReadLine());
            double litersResult = utility.ConvertGallonsToLiters(gallonsInput);
            Console.WriteLine(gallonsInput + " gallons is " + litersResult + " liters");
        }
    }
}
