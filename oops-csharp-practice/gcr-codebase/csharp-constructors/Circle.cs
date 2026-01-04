using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.constructors
{
    public class Circle
    {
        public double radius;

        Circle() : this(10)
        {
            Console.WriteLine("Default constructor");
        }
        Circle(double radius)
        {
            Console.WriteLine("Parameterized Constructor");
            this.radius = radius;
        }
        void DisplayRadius()
        {
            Console.WriteLine("Radius is " + this.radius);
        }
        static void Main(string[] args)
        {
            Circle radius1 = new Circle();
            Circle radius2 = new Circle(10);
            radius1.DisplayRadius();
            radius2.DisplayRadius();
        }

    }
}
