using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class NaturalNumberSum
    {
        public int GetSum(int n) //Method for sum of Natural NUmbers
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            NaturalNumberSum num = new NaturalNumberSum();
            Console.Write("Enter number ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of first "+n+" natural numbers is: "+num.GetSum(n));
        }
    }
}
