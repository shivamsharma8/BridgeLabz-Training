using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class EuclideanDistanceLineEquation
    {
        public static double GetDistance(double x1, double y1, double x2, double y2){
         return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
		}

        public static double[] GetLineParams(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return new double[] { m, b };
        }

        static void Main(string[] args)
        {
            double[] p = GetLineParams(1, 2, 3, 4);
            Console.WriteLine("Slope: "+p[0]+", Intercept: "+p[1]);
        }
    }
}
