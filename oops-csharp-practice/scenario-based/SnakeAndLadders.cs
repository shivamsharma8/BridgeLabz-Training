using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    public class SnakeAndLadders
    {
        public static int CheckSnakeAndLadder(int position, int[] starting, int[] ending)
        {
            for (int i = 0; i < starting.Length; i++)
            {
                if (position == starting[i])
                {
                    position = ending[i];
                    break;
                }

            }
            return position;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players(2-4)");
            int pc = Convert.ToInt32(Console.ReadLine());
            if (pc < 2 || pc > 4)
            {
                Console.WriteLine("No of players are invalid input in range of 2-4");
                return;
            }
            string[] player = new string[pc];
            int[] pos = new int[pc];
            for (int i = 0; i < pc; i++)
            {
                Console.WriteLine("Enter the name of the player");
                player[i] = Console.ReadLine();
                pos[i] = 0;
            }
            int[] starting = { 4, 9, 2, 20, 28, 40, 47, 49, 62, 67, 73, 87, 93, 95, 99 };
            int[] ending = { 23, 31, 7, 38, 82, 59, 67, 34, 33, 60, 91, 24, 73, 79, 2 };
            bool gameOver = false;
            Random random = new Random();
            while (!gameOver)
            {
                for (int i = 0; i < pc; i++)
                {
                    bool extra = true;
                    while (extra)
                    {
                        extra = false;
                        Console.WriteLine();
                        Console.WriteLine(player[i] + "roll the dice(Press Enter)");
                        Console.ReadLine();
                        int dice = random.Next(1, 7);
                        int oldpos = pos[i];
                        int newpos = oldpos + dice;
                        Console.WriteLine("Dice rolled" + dice);
                        if (newpos > 100)
                        {
                            Console.WriteLine("your chance is skipped because you got more than 100");

                        }
                        else
                        {
                            pos[i] = newpos;
                            int before = pos[i];
                            pos[i] = CheckSnakeAndLadder(pos[i], starting, ending);
                            if (before < pos[i])
                            {
                                Console.WriteLine("You climbed the ladder");
                            }
                            else if (before > pos[i])
                            {

                                Console.WriteLine("Snake bite");
                            }
                        }
                        Console.WriteLine("old position" + oldpos + "->" + pos[i]);
                        if (pos[i] == 100)
                        {
                            Console.WriteLine("Congratulations" + player[i] + " for winning the game");
                            gameOver = true;
                            break;
                        }


                        if (dice == 6 && !gameOver)
                        {
                            Console.WriteLine("Extra Chance to roll a dice because you got 6");
                            extra = true;



                        }
                    }
                }
                if (gameover)
                {
                    break;
                }

            }
        }
    }
}

