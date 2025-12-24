using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class Vote
    {
        static void Main(string[] args)
        {
            int num = 10;
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Enter the age of " + (i + 1) + " Student");
                arr[i] = int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < num; i++)
            {

                if (arr[i] < 18)
                {
                    Console.WriteLine((i + 1) + " student can't vote");
                }
                else
                {
                    Console.WriteLine((i + 1) + " student can vote");
                }

            }

        }
    }
}
