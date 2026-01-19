using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.TrafficManager
{
    internal class CircularRoundabout
    {
        private Vehicle head;

        public CircularRoundabout()
        {
            head = null;
        }

        // Add vehicle into roundabout
        public void AddVehicle(string number)
        {
            Vehicle newVehicle = new Vehicle(number);

            if (head == null)
            {
                head = newVehicle;
                newVehicle.Next = head;
            }
            else
            {
                Vehicle temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newVehicle;
                newVehicle.Next = head;
            }

            Console.WriteLine("Vehicle entered roundabout.");
        }

        // Remove vehicle from roundabout (front)
        public void RemoveVehicle()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            if (head.Next == head)
            {
                Console.WriteLine($"Vehicle {head.VehicleNumber} exited.");
                head = null;
            }
            else
            {
                Vehicle temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }

                Console.WriteLine($"Vehicle {head.VehicleNumber} exited.");
                temp.Next = head.Next;
                head = head.Next;
            }
        }

        // Display current roundabout
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Vehicle temp = head;
            Console.Write("Roundabout: ");

            do
            {
                Console.Write(temp.VehicleNumber + " -> ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("(back to start)");
        }
    }
}
