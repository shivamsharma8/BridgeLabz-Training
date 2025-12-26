using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class FactorsOfNumber
    {
        public static int[] GetFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) count++;
            }

            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] factors = GetFactors(num);

            int sum = 0;
            long product = 1;
            double sumSq = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                sum = sum + factors[i];
                product = product * factors[i];
                sumSq = sumSq + Math.Pow(factors[i], 2);
            }

            Console.WriteLine("Sum: " + sum + ", Product: " + product + ", Sum of Squares: " + sumSq);
        }
    }
}
