using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class SpringSeason
    {
        // Method to check for spring season 
        public bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20 && day <= 31) || (month == 4 && day >= 1 && day <= 30) ||
                (month == 5 && day >= 1 && day <= 31) || (month == 6 && day >= 1 && day <= 20))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            SpringSeason check = new SpringSeason();


            Console.WriteLine("Enter the number of Month ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of day ");
            int day = int.Parse(Console.ReadLine());

            if (check.IsSpringSeason(month, day))
            {
                Console.WriteLine("It's a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
            
        }
    }
}
