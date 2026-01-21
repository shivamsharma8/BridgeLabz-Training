using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.queue_interface
{
    internal class HospitalTriage
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> triageQueue = CreateTriageQueue();

            AddPatient(triageQueue, "John", 3);
            AddPatient(triageQueue, "Alice", 5);
            AddPatient(triageQueue, "Bob", 2);

            Console.WriteLine("Treatment Order:");
            TreatPatients(triageQueue);
        }        static PriorityQueue<string, int> CreateTriageQueue()
        {
            return new PriorityQueue<string, int>();
        }        static void AddPatient(PriorityQueue<string, int> queue, string name, int severity)
        {
            queue.Enqueue(name, -severity);
        }        static void TreatPatients(PriorityQueue<string, int> queue)
        {
            while (queue.Count > 0)
            {
                string patient = queue.Dequeue();
                Console.WriteLine(patient);
            }
        }
    }
}
