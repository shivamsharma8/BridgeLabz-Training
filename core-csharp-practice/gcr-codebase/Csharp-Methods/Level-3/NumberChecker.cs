using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class NumberChecker
    {
        public static int[] GetDigits(int n)
        {
            string s = n.ToString();
            int[] digits = new int[s.Length];
            for (int i = 0; i < s.Length; i++) digits[i] = int.Parse(s[i].ToString());
            return digits;
        }

        public static bool IsDuck(int[] digits)
        {
            foreach (int d in digits) if (d != 0) return true;
            return false;
        }

        public static bool IsArmstrong(int n, int[] digits)
        {
            double sum = 0;
            foreach (int d in digits) sum += Math.Pow(d, digits.Length);
            return (int)sum == n;
        }

        static void Main(string[] args)
        {
            int num = 153;
            int[] d = GetDigits(num);
            Console.WriteLine("Is Duck: " + IsDuck(d));
            Console.WriteLine("Is Armstrong: " + IsArmstrong(num, d));
        }
    }
}
