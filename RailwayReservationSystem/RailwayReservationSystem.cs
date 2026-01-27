using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    internal class RailwayReservationSystem
    {
        static PassengerService service = new PassengerService();
        static void Main(string[] args)
        {
            
            int choice;
            do
            {
                Console.WriteLine("Ticket Reservation System");
                Console.WriteLine("1. Add Ticket");
                Console.WriteLine("2. Display Ticket");
                Console.WriteLine("3. Sort Tickets - By PR number");
                Console.WriteLine("4. Search Ticket - By PR number");
                Console.WriteLine("5. To See the Difference Between Ticket Fare");
                Console.WriteLine("6. To Exit");
                Console.WriteLine("Enter Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPassenger();
                        break;
                        
                    case 2:
                        DisplayPassengers();
                        break;
                    case 3:
                        SortPassengers();
                        break;
                    case 4:
                        SearchPassenger();
                        break;
                    case 5:
                        FareDifference();
                        break;
                    case 6:

                        break;
                }
            } while (choice != 6);


            static void AddPassenger()
            {
                Console.Write("Enter PR No: ");
                int pr = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Passenger p;
                if (age >= 60)
                    p = new SeniorPassenger();
                else
                    p = new NormalPassenger();

                p.PRNo = pr;
                p.Name = name;
                p.Age = age;

                service.AddPassenger(p);
            }

            static void DisplayPassengers()
            {
                foreach (var p in service.GetPassengers())
                    p.Display();
            }

            static void SortPassengers()
            {
                var sorted = SortUtility.MergeSort(service.GetPassengers());
                Console.WriteLine("Passengers sorted by PR No:");
                foreach (var p in sorted)
                    p.Display();
            }

            static Passenger BinarySearchPassenger(List<Passenger> passengers, int prNo)
            {
                int low = 0;
                int high = passengers.Count - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;

                    if (passengers[mid].PRNo == prNo)
                        return passengers[mid];

                    else if (passengers[mid].PRNo < prNo)
                        low = mid + 1;

                    else
                        high = mid - 1;
                }

                return null; // Not found
            }


            static void SearchPassenger()
            {
                Console.Write("Enter PR No: ");
                int pr = int.Parse(Console.ReadLine());

                var p = service.SearchByPRNo(pr);

                if (p != null)
                    p.Display();
                else
                    Console.WriteLine("Passenger not found.");
            }



            static void FareDifference()
            {
                double normal = 500;
                double senior = 500 * 0.5;
                Console.WriteLine($"Fare Difference: {normal - senior}");
            }





        }
        

    }
}
