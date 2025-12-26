using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class TrignometricFunction
    {
        public double[] calculateTrigonometricFunctions(double angle)
        {
            double radians = angle * (Math.PI / 180.0); // Convert to radians 
            return new double[] {Math.Sin(radians), Math.Cos(radians), Math.Tan(radians)};
        }

        static void Main()
        {
            TrignometricFunction tc = new TrignometricFunction();
            Console.Write("Enter angle in degrees: ");
            double angle = double.Parse(Console.ReadLine());

            double[] results = tc.calculateTrigonometricFunctions(angle);
            Console.WriteLine("Sine: "+results[0]+" Cosine: "+ results[1]+" Tangent: " + results[2]);
        }
    }
}
