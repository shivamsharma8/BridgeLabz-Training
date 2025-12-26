using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class ChocolateDistribution
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int q = number / divisor; // quotient 
            int r = number % divisor; // remainder 
            return new int[] { q, r };
        }

        static void Main(string[] args)
        {
            
            Console.Write("Enter number of chocolates: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter number of People: ");
            int div = int.Parse(Console.ReadLine());

            int[] outcome = FindRemainderAndQuotient(num, div);
            Console.WriteLine("Each children will get " + outcome[0] + "chocolates and  Remaining chocolates are: " + outcome[1]);
        }
    }
}
