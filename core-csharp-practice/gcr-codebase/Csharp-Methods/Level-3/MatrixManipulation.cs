using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class MatrixManipulation
    {
        public static int[,] Add(int[,] a, int[,] b, int r, int c)
        {
            int[,] res = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++) res[i, j] = a[i, j] + b[i, j];
            return res;
        }

        public static int[,] Transpose(int[,] a, int r, int c)
        {
            int[,] res = new int[c, r];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++) res[j, i] = a[i, j];
            return res;
        }

        static void Main(string[] args)
        {
            int[,] m = { { 1, 2 }, { 3, 4 } };
            int[,] t = Transpose(m, 2, 2);
            Console.WriteLine("Transposed [0,1]: " + t[0, 1]);
        }
    }
}
