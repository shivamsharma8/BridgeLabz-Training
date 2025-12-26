using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class CollinearPoints
    {
        public static bool CheckSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
        }

        public static double GetArea(double x1, double y1, double x2, double y2, double x3, double y3){
            return(0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));
		}

        static void Main(string[] args)
        {
            Console.WriteLine("Area is zero: " + (GetArea(2, 4, 4, 6, 6, 8) == 0));
        }
    }
}
