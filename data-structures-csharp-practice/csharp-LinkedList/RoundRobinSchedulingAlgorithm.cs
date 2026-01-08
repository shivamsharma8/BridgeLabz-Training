using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    class ProcessNode
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;

        public int CompletionTime;
        public int WaitingTime;
        public int TurnAroundTime;

        public ProcessNode Next;

        public ProcessNode(int pid, int burstTime, int priority)
        {
            ProcessId = pid;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }

    class RoundRobinScheduler
    {
        private ProcessNode head;
        private ProcessNode tail;

        private int timeQuantum;
        private int currentTime = 0;

        private int totalProcesses = 0;
        private int completedCount = 0;
        private double totalWaitingTime = 0;
        private double totalTurnAroundTime = 0;

        public RoundRobinScheduler(int quantum)
        {
            timeQuantum = quantum;
        }

        // Add process at end
        public void AddProcess(int pid, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(pid, burstTime, priority);

            if (head == null)
            {
                head = tail = newNode;
                newNode.Next = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Next = head;
                tail = newNode;
            }

            totalProcesses++;
        }

        // Start round-robin scheduling
        public void StartScheduling()
        {
            if (head == null)
            {
                Console.WriteLine("No processes to schedule.");
                return;
            }

            ProcessNode current = head;
            ProcessNode prev = tail;

            while (head != null)
            {
                Console.WriteLine($" Current Time: {currentTime}");
                DisplayQueue();

                if (current.RemainingTime > timeQuantum)
                {
                    currentTime += timeQuantum;
                    current.RemainingTime -= timeQuantum;

                    prev = current;
                    current = current.Next;
                }
                else
                {
                    currentTime += current.RemainingTime;
                    current.RemainingTime = 0;

                    current.CompletionTime = currentTime;
                    current.TurnAroundTime = currentTime;
                    current.WaitingTime =
                        current.TurnAroundTime - current.BurstTime;

                    totalWaitingTime += current.WaitingTime;
                    totalTurnAroundTime += current.TurnAroundTime;
                    completedCount++;

                    Console.WriteLine($" Process P{current.ProcessId} completed");

                    RemoveProcess(current, prev);

                    if (head == null)
                        break;

                    current = prev.Next;
                }
            }

            DisplayAverages();
        }

        // Remove a node from circular list
        private void RemoveProcess(ProcessNode current, ProcessNode prev)
        {
            if (current == head && current == tail)
            {
                head = tail = null;
                return;
            }

            if (current == head)
            {
                head = head.Next;
                tail.Next = head;
            }
            else if (current == tail)
            {
                tail = prev;
                tail.Next = head;
            }
            else
            {
                prev.Next = current.Next;
            }
        }

        // Display queue after each round
        private void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            ProcessNode temp = head;
            do
            {
                Console.Write($"Process ID{temp.ProcessId}(Remaining Time:{temp.RemainingTime}) → ");
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("(back to head)");
        }

        private void DisplayAverages()
        {
            Console.WriteLine("Final Statistics");
            Console.WriteLine("Total Processes: " + totalProcesses);

            Console.WriteLine("Average Waiting Time = " +(totalWaitingTime / totalProcesses));

            Console.WriteLine("Average Turnaround Time = " +(totalTurnAroundTime / totalProcesses));
        }
    }

    class RoundRobinSchedularAlgorithm
    {
        static void Main(string[] args)
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler(2); 

            scheduler.AddProcess(1, 5, 1);
            scheduler.AddProcess(2, 3, 2);
            scheduler.AddProcess(3, 8, 1);

            scheduler.StartScheduling();
        }
    }
}
