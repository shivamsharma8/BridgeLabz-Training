using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Scenario_Based
{
    internal class SnakeAndLadder
    {
        static Random random = new Random();

        // Snake and Ladder 
        static int[] snakeStart = { 25, 52, 70, 99 };
        static int[] snakeEnd = { 5, 42, 55, 10 };

        static int[] ladderStart = { 3, 11, 40, 60 };
        static int[] ladderEnd = { 22, 49, 80, 95 };

        static void Main(string[] args)
        {
            Console.WriteLine("SNAKE & LADDER GAME");

            Console.Write("Enter number of players (2-4): ");
            int playerCount = Convert.ToInt32(Console.ReadLine());

            if (playerCount < 2 || playerCount > 4)
            {
                Console.WriteLine("Invalid Players must be between 2 to 4.");
                return;
            }

            string[] players = new string[playerCount];
            int[] pos = new int[playerCount];

            // Taking user names
            for (int i = 0; i < playerCount; i++)
            {
                Console.Write("Enter Player " + (i + 1) + " Name: ");
                players[i] = Console.ReadLine();
                pos[i] = 0;
            }

            Console.WriteLine("\nGame Started Reach EXACT 100 to Win");
            Console.WriteLine("Press ENTER to roll dice\n");

            bool gameOn = true;

            while (gameOn)
            {
                for (int turn = 0; turn < playerCount; turn++)
                {
                    Console.WriteLine("");
                    Console.WriteLine(players[turn] + "'s turn");
                    Console.WriteLine("Press ENTER to roll dice");
                    Console.ReadLine(); 

                    int dice = RollDice();
                    Console.WriteLine("Dice Rolled: " + dice);

                    int oldPos = pos[turn];
                    int newPos = oldPos + dice;

                    if (newPos > 100)
                    {
                        Console.WriteLine("Move exceeds 100");
                        Console.WriteLine("Position remains: " + pos[turn] + "\n");
                        continue;
                    }

                    pos[turn] = newPos;

                    pos[turn] = ApplySnakeOrLadder(pos[turn]);

                    Console.WriteLine("Position: " +oldPos + " - " +pos[turn]);

                    if (pos[turn] == 100)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(players[turn] + " WINS");
                        Console.WriteLine("");
                        gameOn = false;
                        break;
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nGame Over. Thanks for playing");
        }

        
        static int RollDice()
        {
            return random.Next(1, 7); 
        }

        static int ApplySnakeOrLadder(int pos)
        {
            // Snake 
            for (int i = 0; i < snakeStart.Length; i++)
            {
                if (pos == snakeStart[i])
                {
                    Console.WriteLine("Snake Bite Slide to " + snakeEnd[i]);
                    return snakeEnd[i];
                }
            }

            // Ladder 
            for (int i = 0; i < ladderStart.Length; i++)
            {
                if (pos == ladderStart[i])
                {
                    Console.WriteLine("Ladder Climb to " + ladderEnd[i]);
                    return ladderEnd[i];
                }
            }

            return pos;
        }
    }

}
