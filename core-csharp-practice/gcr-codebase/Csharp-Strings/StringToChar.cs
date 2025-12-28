using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class StringToChar
    {
        public static int[] Convert(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
            return arr;

        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Convert(str));
        }
    }
}
