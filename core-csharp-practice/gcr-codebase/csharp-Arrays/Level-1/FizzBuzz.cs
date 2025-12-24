using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());

            string[] arr = new string[number + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    arr[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    arr[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    arr[i] = "Buzz";
                }
                else
                {
                    arr[i] = i.ToString();
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
