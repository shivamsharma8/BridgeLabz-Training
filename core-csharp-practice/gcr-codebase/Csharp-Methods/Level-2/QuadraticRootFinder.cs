using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class QuadraticRootFinder
    {
        // Method to find and return roots in an array 
        public double[] FindRoots(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c); // Formula [cite: 212]

            if (delta > 0)
            {
                double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { r1, r2 };
            }
            else if (delta == 0)
            {
                return new double[] { -b / (2 * a) };
            }

            return new double[0];
        }

        static void Main(string[] args)
        {
            QuadraticRootFinder q = new QuadraticRootFinder();
            Console.WriteLine("Enter a, b, and c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double[] roots = q.FindRoots(a, b, c);

            if (roots.Length == 0) Console.WriteLine("No real roots.");
            for (int i = 0; i < roots.Length; i++)
            {
                Console.WriteLine("Root: " + roots[i]);
            }
        }
    }
}
