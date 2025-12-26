using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class HarshadFrequency
    {
        public static bool IsHarshad(int n, int sum){
			return n % sum == 0;
		}

        public static int[,] GetFrequency(int[] digits)
        {
            int[,] freq = new int[10, 2];
            for (int i = 0; i < 10; i++) freq[i, 0] = i;
            foreach (int d in digits) freq[d, 1]++;
            return freq;
        }

        static void Main(string[] args)
        {
            int num = 21;
            int[] digits = { 2, 1 };
            Console.WriteLine("Is Harshad: " + IsHarshad(num, 3));
        }
    }
}
