using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.scenario_based
{
    public class FestivalLuckyDraw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of visitors");
            int numberOfVisitors = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numberOfVisitors; i++)
            {
                Console.WriteLine("Enter the lucky number for visitor " + i);
                int luckyNumber;
                string inputNumber = Console.ReadLine();
                if(!int.TryParse(inputNumber, out luckyNumber)|| luckyNumber <= 0)
                {
                    Console.WriteLine("Not valid, skipping the visitor");
                    continue;
                }
                if (luckyNumber % 3 == 0 && luckyNumber % 5 == 0)
                {
                    Console.WriteLine("Congratulations you won the prize");
                }
                else
                {
                    Console.WriteLine("Better luck next time");
                }
            }
            Console.WriteLine("Lucky draw event completed");
        }
    }
}
