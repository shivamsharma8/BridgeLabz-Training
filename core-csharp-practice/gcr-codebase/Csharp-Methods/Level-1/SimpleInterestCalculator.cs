using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class SimpleInterestCalculator
    {
        public double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100; // Formula= P*R*T/100 
        }
        static void Main(string[] args)
        {
            SimpleInterestCalculator calculator = new SimpleInterestCalculator();

            Console.Write("Enter Principal ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time ");
            double time = double.Parse(Console.ReadLine());

            double interest = calculator.CalculateSimpleInterest(principal, rate, time);
            Console.WriteLine("The Simple Interest is "+ interest +" for Principal "+principal+" , Rate of Interest "+rate+" and Time" + time);
    }
    }
}
