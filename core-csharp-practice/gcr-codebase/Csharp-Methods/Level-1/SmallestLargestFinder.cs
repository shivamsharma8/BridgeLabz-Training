using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{
    internal class SmallestLargestFinder
    {
      
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)//Method to find Smallest and Largest
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));
            int largest = Math.Max(number1, Math.Max(number2, number3));
            int[] answer = {  smallest, largest };
            
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:"); 
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int[] results = FindSmallestAndLargest(n1, n2, n3);
            Console.WriteLine("Smallest: " + results[0] +", Largest: "+ results[1]);
        }
    }
}
