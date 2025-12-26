using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class StudentScoreCard
    {
        static void Main(string[] args)
        {
            int students = 5;
            Random r = new Random();
            for (int i = 0; i < students; i++)
            {
                int p = r.Next(30, 100), c = r.Next(30, 100), m = r.Next(30, 100);
                double avg = (p + c + m) / 3.0;
                string grade = avg >= 80 ? "A" : (avg >= 70 ? "B" : "C");
                Console.WriteLine("Student "+(i + 1)+": Avg "+Math.Round(avg, 2)+" Grade "+grade);
            }
        }
    }
}
