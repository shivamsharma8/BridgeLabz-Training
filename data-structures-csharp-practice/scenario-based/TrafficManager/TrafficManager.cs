using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.TrafficManager
{
    internal class TrafficManager
    {
        static void Main(string[] args)
        {
            CircularRoundabout roundabout = new CircularRoundabout();
            VehicleQueue queue = new VehicleQueue(5);

            int choice;
            string number;

            do
            {
                Console.WriteLine("\n--- Traffic Manager ---");
                Console.WriteLine("1. Add vehicle to waiting queue");
                Console.WriteLine("2. Move vehicle into roundabout");
                Console.WriteLine("3. Remove vehicle from roundabout");
                Console.WriteLine("4. Display roundabout");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter vehicle number: ");
                        number = Console.ReadLine();
                        queue.Enqueue(number);
                        break;

                    case 2:
                        string vehicle = queue.Dequeue();
                        if (vehicle != null)
                            roundabout.AddVehicle(vehicle);
                        break;

                    case 3:
                        roundabout.RemoveVehicle();
                        break;

                    case 4:
                        roundabout.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }

    }
}
