using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class NNaturalNumberSum
    {
        public int RecursiveSum(int n)
        {
            if (n <= 1) return n;
            return n + RecursiveSum(n - 1);
        }

        public int FormulaSum(int n)
        {
            return (n * (n + 1)) / 2;
        }

        static void Main(string[] args)
        {
            NNaturalNumberSum sc = new NNaturalNumberSum();
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Recursive sum: " + sc.RecursiveSum(number));
            Console.WriteLine("Formula sum: " + sc.FormulaSum(number));
        }
    }
}
