using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class SumOfNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            Console.WriteLine("Enter the numbers");

            bool flag = true;
            int i = 0;
            while (i < 10)
            {

                double temp = double.Parse(Console.ReadLine());
                if (temp <= 0)
                {
                    break;
                }
                else
                {
                    arr[i] = temp;
                }
                i++;

            }
            double sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == 0) break;
                Console.WriteLine(arr[j]);
                sum = sum + arr[j];
            }
            Console.WriteLine("The sum of numbers is " + sum);
        }
    }
}
