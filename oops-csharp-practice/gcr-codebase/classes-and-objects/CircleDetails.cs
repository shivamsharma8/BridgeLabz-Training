using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.class_and_object
{
    public class CircleDetails
    {
        double radius;
        double areaOfCircle;
        double circumferenceOfCircle;
        
        public CircleDetails (double enteredRadius)
        {
            this.radius = enteredRadius;
        }
        void CalculateAreaAndCircumference()
        {
             areaOfCircle = 3.14*(radius*radius);
             circumferenceOfCircle = 2 * 3.14 * radius;

        }
        void DisplayAreaAndCircumference()
        {
            Console.WriteLine("Area and circumference of circle are given below");
            Console.WriteLine("Area Of Circle is: "+areaOfCircle);
            Console.WriteLine("Circumference Of circle is : " + circumferenceOfCircle);

        }
        static void Main(string[] args)
        {
            CircleDetails radius1 = new CircleDetails(4);
            radius1 .CalculateAreaAndCircumference();
            radius1 .DisplayAreaAndCircumference();

        }
    }
}
