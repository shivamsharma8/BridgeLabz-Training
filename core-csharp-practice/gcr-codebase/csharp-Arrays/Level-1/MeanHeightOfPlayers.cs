using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.Level_1
{
    internal class MeanHeightOfPlayers
    {
        static void Main(string[] args)
        {
            double[] arr = new double[11];
            double sum = 0;

            Console.WriteLine("Enter the height of players ");
            for (int i = 0; i < arr.Length; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                arr[i] = temp;
                sum += temp;
            }

            double MeanHeightOfPlayers = sum / arr.Length;
            Console.WriteLine("The mean height of the footbal team is " + MeanHeightOfPlayers);
        }
    }
}
