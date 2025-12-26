using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class ZaraEmployeeBonus
    {
        static void Main(string[] args)
        {
            double[,] data = new double[10, 4]; // Salary, Years, Bonus, NewSalary
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                data[i, 0] = r.Next(20000, 90000);
                data[i, 1] = r.Next(1, 15);
                double rate = data[i, 1] > 5 ? 0.05 : 0.02;
                data[i, 2] = data[i, 0] * rate;
                data[i, 3] = data[i, 0] + data[i, 2];
                Console.WriteLine("Employee "+i + 1+": Bonus "+data[i, 2]+", New Salary "+data[i, 3]);
            }
        }
    }
}
