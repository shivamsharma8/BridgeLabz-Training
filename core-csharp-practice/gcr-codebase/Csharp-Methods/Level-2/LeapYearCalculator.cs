using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class LeapYearCalculator
    {
        public bool CheckLeap(int year)
        {
            if (year < 1582) return false;
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            LeapYearCalculator calculate = new LeapYearCalculator();
            Console.Write("Year: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Is LeapYear: " + calculate.CheckLeap(y));
        }
    }
}
