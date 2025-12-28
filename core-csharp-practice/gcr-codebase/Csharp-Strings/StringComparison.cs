using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class StringComparison
    {

        public static bool CompareString(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i] ) return false; 
            }
            return true;

             
        }
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            if(CompareString(string1, string2))
            {
                Console.WriteLine("Given Strings are Equal");
            }
            else
            {
                Console.WriteLine("Given Strings are not Equal");
            }
        }
    }
}
