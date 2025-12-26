using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class StudentVoteChecker
    {
        public bool CanVote(int age)
        {
            if (age < 0) return false;
            return age >= 18;
        }

        static void Main(string[] args)
        {
            StudentVoteChecker check = new StudentVoteChecker();
            int[] ages = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Age for student " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Can Vote: " + check.CanVote(ages[i]));
            }
        }
    }
}
