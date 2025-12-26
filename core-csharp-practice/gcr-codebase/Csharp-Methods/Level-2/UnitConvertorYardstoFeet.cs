using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class UnitConvertorYardstoFeet
    {
        public double ConvertYardsToFeet(double lengthInYards)
        {
            return lengthInYards * 3;
        }

        public double ConvertFeetToYards(double lengthInFeet)
        {
            return lengthInFeet / 3;
        }

        public double ConvertMetersToInches(double lengthInMeters)
        {
            return lengthInMeters * 39.3701;
        }

        public double ConvertInchesToMeters(double lengthInInches)
        {
            return lengthInInches * 0.0254;
        }

        public double ConvertInchesToCentimeters(double lengthInInches)
        {
            return lengthInInches * 2.54;
        }

        static void Main(string[] args)
        {
            UnitConvertorYardstoFeet convert = new UnitConvertorYardstoFeet();

            Console.Write("Enter length in yards: ");
            double yardsInput = double.Parse(Console.ReadLine());
            double feetOutput = convert.ConvertYardsToFeet(yardsInput);
            Console.WriteLine(yardsInput + " yards is " + feetOutput + " feet");

            Console.Write("Enter length in inches: ");
            double inchesInput = double.Parse(Console.ReadLine());
            double centimetersOutput = convert.ConvertInchesToCentimeters(inchesInput);
            Console.WriteLine(inchesInput + " inches is " + centimetersOutput + " centimeters");
        }
    }
}
