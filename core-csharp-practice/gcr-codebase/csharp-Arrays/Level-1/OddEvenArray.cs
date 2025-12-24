using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class OddEvenArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            else
            {
                int[] Odd = new int[(number / 2)];
                int[] Even = new int[(number / 2)];
                int index = 0;
                for (int i = 1; i <= number; i += 2)
                {
                    Odd[index] = i;
                    Even[index] = i + 1;
                    index++;
                }

                Console.WriteLine("Odd Array");
                for (int i = 0; i < number / 2; i++)
                {
                    Console.Write(Odd[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Even Array");
                for (int i = 0; i < number / 2; i++)
                {
                    Console.Write(Even[i] + " ");
                }
            }
        }
    }
}
