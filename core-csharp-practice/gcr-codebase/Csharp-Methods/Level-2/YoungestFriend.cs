using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class YoungestFriend
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            double[] heights = new double[3];
            string[] names = { "Amar", "Akbar", "Anthony" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter age and height for " + names[i] + ":");
                ages[i] = int.Parse(Console.ReadLine());
                heights[i] = double.Parse(Console.ReadLine());
            }

            int minAgeIdx = 0;
            int maxHtIdx = 0;

            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[minAgeIdx]) minAgeIdx = i;
                if (heights[i] > heights[maxHtIdx]) maxHtIdx = i;
            }

            Console.WriteLine("Youngest: " + names[minAgeIdx]);
            Console.WriteLine("Tallest: " + names[maxHtIdx]);
        }
    }
}
