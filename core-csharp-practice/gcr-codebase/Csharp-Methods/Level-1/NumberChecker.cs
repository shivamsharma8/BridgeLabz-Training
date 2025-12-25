using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class NumberChecker
    {
        public int CheckSign(int number)
        {
            if (number > 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            NumberChecker check = new NumberChecker();
            Console.Write("Enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + check.CheckSign(input));
        }
    }
}
