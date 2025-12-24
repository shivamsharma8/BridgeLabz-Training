using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class Factors
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());
            int maxFactor = 10;
            int index = 0;
            int[] factor = new int[maxFactor];


            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {

                    if (index == maxFactor)
                    {
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];

                        for (int j = 0; j < factor.Length; j++)
                        {
                            temp[j] = factor[j];

                            factor = temp;
                        }
                    }
                    factor[index] = i;
                    index++;
                }
            }
            Console.WriteLine("factor of " + number + " :");
            for (int i = 0; i < index; i++)
            {

                Console.WriteLine(factor[i] + " ");
            }


        }
    }
}
