using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class RandomNumber
    {
        // Method to generate 4-digit random array 
        public int[] Generate4DigitRandomArray(int size)
        {
            Random rand = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rand.Next(1000, 10000);
            }
            return numbers;
        }

        // Method to find average, min, and max
        public double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0], max = numbers[0];
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
                sum += numbers[i];
            }

            return new double[] { sum / numbers.Length, min, max };
        }

        static void Main(string[] args)
        {
            RandomNumber rs = new RandomNumber();
            int[] vals = rs.Generate4DigitRandomArray(5); // Size as parameter

            Console.WriteLine("Generated: " + string.Join(", ", vals));
            double[] stats = rs.FindAverageMinMax(vals);

            Console.WriteLine("Average: " + stats[0]);
            Console.WriteLine("Min: " + stats[1]);
            Console.WriteLine("Max: " + stats[2]);
        }
    }
}
