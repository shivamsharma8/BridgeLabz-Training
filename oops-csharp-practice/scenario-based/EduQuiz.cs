using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    internal class EduQuiz
    {

        static int CalculateScore(string[] correctAnswers, string[] studentAnswers)
        {
            int score = 0;
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }
        static void Main(string[] args)
        {
            string[] correctAnswers = { "A", "B", "C", "D", "A", "C", "B", "D", "A", "C" };
            string[] studentAnswers = { "a", "B", "D", "D", "A", "c", "b", "A", "A", "c" };
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question" + (i + 1) + "is correct");
                }
                else
                {
                    Console.WriteLine("Question" + (i + 1) + "is not correct");
                }
            }
            int score = CalculateScore(correctAnswers, studentAnswers);
            double percentage = (score / 10.0) * 100;
            Console.WriteLine("Final Result");
            Console.WriteLine("score: " + score);
            Console.WriteLine("percentage: " + percentage + "%");
            if (percentage >= 33)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }


    }
}
