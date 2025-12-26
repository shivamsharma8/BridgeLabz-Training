using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class FactorsAnalysis
    {
        public static int[] GetFactors(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) count++;

            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) factors[index++] = i;
            return factors;
        }

        public static int GetFactorSum(int[] factors)
        {
            int sum = 0;
            foreach (int f in factors) sum += f;
            return sum;
        }

        // Strong number: sum of factorial of digits == number
        public static bool IsStrong(int n)
        {
            int temp = n, sum = 0;
            while (temp > 0)
            {
                int d = temp % 10, fact = 1;
                for (int i = 1; i <= d; i++) fact *= i;
                sum += fact;
                temp /= 10;
            }
            return sum == n;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int[] factors = GetFactors(num);
            int sum = GetFactorSum(factors);

            Console.WriteLine("Perfect Number: " + (sum == num));
            Console.WriteLine("Abundant: " + (sum > num));
            Console.WriteLine("Deficient: " + (sum < num));
            Console.WriteLine("Strong Number: " + IsStrong(num));
        }   
    }
}
