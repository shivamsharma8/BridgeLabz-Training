using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class WindChill
    {
        public double CalculateWindChill(double temperature, double windSpeed)
        {
            // Formula: 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * windSpeed^0.16
            return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        }

        static void Main(string[] args)
        {
            WindChill wc = new WindChill();
            Console.Write("Enter Temperature: ");
            double temperature = double.Parse(Console.ReadLine());
            Console.Write("Enter Wind Speed: ");
            double windSpeed = double.Parse(Console.ReadLine());

            Console.WriteLine("Wind Chill: " + wc.CalculateWindChill(temperature, windSpeed));
        }
    }
}
