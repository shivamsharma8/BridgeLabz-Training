using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class Table6to9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 6) * num;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(num + " * " + (i + 6) + " = " + arr[i]);
            }
        }
    }
}
