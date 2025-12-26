using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class HeightAnalyzer
    {
        public static int GetSum(int[] heights)
        {
            int total = 0;
            foreach (int h in heights) total += h;
            return total;
        }

        public static double GetMean(int[] heights)
        {
            return (double)GetSum(heights) / heights.Length;
        }

        public static int GetShortest(int[] heights)
        {
            int min = heights[0];
            foreach (int h in heights) if (h < min) min = h;
            return min;
        }

        public static int GetTallest(int[] heights)
        {
            int max = heights[0];
            foreach (int h in heights) if (h > max) max = h;
            return max;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] playerHeights = new int[11];
            for (int i = 0; i < 11; i++) playerHeights[i] = rand.Next(150, 251);

            Console.WriteLine("Mean: " + GetMean(playerHeights));
            Console.WriteLine("Shortest: " + GetShortest(playerHeights));
            Console.WriteLine("Tallest: " + GetTallest(playerHeights));
        }
    }
}
