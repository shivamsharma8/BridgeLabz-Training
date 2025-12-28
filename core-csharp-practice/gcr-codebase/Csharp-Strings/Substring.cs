using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class Substring
    {
            
        public static string Slicer(string s1, int start, int end)
        {
            return s1.Substring(start, end);
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The Substring for the Given String is "+ Slicer(str,start,end));

        }
    }
}
