using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class OTPGenerator
    {
        public static string GenerateOtp(){
			return (new Random().Next(100000, 1000000).ToString());
		}

        public static bool IsUnique(string[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
                for (int j = i + 1; j < otps.Length; j++)
                    if (otps[i] == otps[j]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            string[] list = new string[10];
            for (int i = 0; i < 10; i++) list[i] = GenerateOtp();
            Console.WriteLine("Are unique: " + IsUnique(list));
        }
    }
}
