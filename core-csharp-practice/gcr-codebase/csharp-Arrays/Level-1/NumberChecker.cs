using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class NumberChecker
    {
        static void Main(string[] args)
        {

            int num = 5;
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " number");
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < num; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] < 0)
                    {
                        Console.WriteLine("Even and Negative");
                    }
                    else if (arr[i] > 0)
                    {
                        Console.WriteLine("Even and Positive");
                    }
                    else
                    {
                        Console.WriteLine("NUmber is Zero");
                    }
                }
                //else if (arr[i] % 2 != 0)
                else
                {
                    if (arr[i] < 0)
                    {
                        Console.WriteLine("Odd and Negative");
                    }
                    else if (arr[i] > 0)
                    {
                        Console.WriteLine("Odd and Positive");
                    }
                    else
                    {
                        Console.WriteLine("NUmber is Zero");
                    }

                }


            }
            if (arr[0] > arr[num - 1])
            {
                Console.WriteLine("First is greater than Last");
            }
            else if (arr[0] < arr[num - 1])
            {
                Console.WriteLine("Last is greater than First");
            }
            else
            {
                Console.WriteLine("Both First and Last are equal");
            }

        }
    }
}
