using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class ArrayConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows and columns respectively");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            Console.WriteLine("enter the elements");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[] array2 = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2[index] = array[i, j];
                    index++;
                }
            }

            Console.WriteLine("elements copied in 1D array are: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
        }
    }
}
