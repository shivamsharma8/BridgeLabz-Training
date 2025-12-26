using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class Calendar
    {
        public static bool IsLeap(int y){
			return(((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0));
		}

        static void Main(string[] args)
        {
            int m = 7, y = 2005;
            DateTime dt = new DateTime(y, m, 1);
            int startDay = (int)dt.DayOfWeek;
            int days = DateTime.DaysInMonth(y, m);

            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            for (int i = 0; i < startDay; i++) Console.Write("    ");
            for (int i = 1; i <= days; i++)
            {
                Console.Write(i.ToString().PadLeft(3) + " ");
                if ((i + startDay) % 7 == 0) Console.WriteLine();
            }
        }
    }
}
