using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class Athlete
    {
        public double CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3; 
            double totalDistanceMeters = 5000; // 5 km converted to meters
            return totalDistanceMeters / perimeter; // rounds = distance/perimeter
        }

        static void Main()
        {
            Athlete run = new Athlete();

            Console.WriteLine("Enter the sides of the triangle ");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            double rounds = run.CalculateRounds(side1, side2, side3);
            Console.WriteLine("The athlete must complete "+Math.Ceiling(rounds)+" rounds");
        }
    }
}
