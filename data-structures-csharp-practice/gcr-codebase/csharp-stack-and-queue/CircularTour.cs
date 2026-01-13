using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.StackAndQueue
{
    class CircularTourProblem
    {
        public static int FindStartingPetrolPump(int[] petrolAvailable, int[] distanceToNextPump)
        {
            int numberOfPumps = petrolAvailable.Length;

            int startingPumpIndex = 0;
            int currentSurplusPetrol = 0;
            int totalPetrolDeficit = 0;

            for (int currentPump = 0; currentPump < numberOfPumps; currentPump++)
            {
                int petrolBalance = petrolAvailable[currentPump] - distanceToNextPump[currentPump];
                currentSurplusPetrol += petrolBalance;

                if (currentSurplusPetrol < 0)
                {
                    totalPetrolDeficit += currentSurplusPetrol;
                    startingPumpIndex = currentPump + 1;
                    currentSurplusPetrol = 0;
                }
            }

            if (currentSurplusPetrol + totalPetrolDeficit >= 0)
            {
                return startingPumpIndex;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] petrolAvailable = { 4, 6, 7, 4 };
            int[] distanceToNextPump = { 6, 5, 3, 5 };

            int startingIndex = FindStartingPetrolPump(petrolAvailable, distanceToNextPump);

            if (startingIndex != -1)
                Console.WriteLine("Start tour from petrol pump index: " + startingIndex);
            else
                Console.WriteLine("No possible circular tour");
        }
    }
}
