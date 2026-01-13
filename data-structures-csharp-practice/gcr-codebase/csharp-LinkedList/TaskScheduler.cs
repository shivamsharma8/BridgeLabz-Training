using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    // Node class
    public class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    // Circular Linked List
    class TaskCircularLinkedList
    {
        private TaskNode head;
        private TaskNode current;

        // Add at beginning
        public void AddAtBeginning(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                newNode.Next = head;
                return;
            }

            TaskNode temporaryTraversal = head;
            while (temporaryTraversal.Next != head)
            {
                temporaryTraversal = temporaryTraversal.Next;
            }

            newNode.Next = head;
            temporaryTraversal.Next = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                newNode.Next = head;
                return;
            }

            TaskNode temporaryTraversal = head;
            while (temporaryTraversal.Next != head)
            {
                temporaryTraversal = temporaryTraversal.Next;
            }

            temporaryTraversal.Next = newNode;
            newNode.Next = head;
        }

        // Add at specific position
        public void AddAtPosition(int position, int id, string name, int priority, DateTime dueDate)
        {
            if (position <= 1 || head == null)
            {
                AddAtBeginning(id, name, priority, dueDate);
                return;
            }

            TaskNode temporaryTraversal = head;
            for (int i = 1; i < position - 1 && temporaryTraversal.Next != head; i++)
            {
                temporaryTraversal = temporaryTraversal.Next;
            }

            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            newNode.Next = temporaryTraversal.Next;
            temporaryTraversal.Next = newNode;
        }

        // Remove task by ID
        public void RemoveByTaskId(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            TaskNode temporaryTraversal = head;
            TaskNode prev = null;

            do
            {
                if (temporaryTraversal.TaskId == id)
                {
                    if (temporaryTraversal == head)
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        if (head == head.Next)
                        {
                            head = current = null;
                            return;
                        }

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = temporaryTraversal.Next;
                    }

                    if (current == temporaryTraversal)
                        current = temporaryTraversal.Next;

                    Console.WriteLine("Task removed successfully");
                    return;
                }

                prev = temporaryTraversal;
                temporaryTraversal = temporaryTraversal.Next;

            } while (temporaryTraversal != head);

            Console.WriteLine("Task not found");
        }

        // View current task & move to next
        public void ViewNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            Console.WriteLine($"Current Task: {current.TaskName} | Priority: {current.Priority}");
            current = current.Next;
        }

        // Display all tasks
        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks to display");
                return;
            }

            TaskNode temporaryTraversal = head;
            do
            {
                Console.WriteLine($"{temporaryTraversal.TaskId} | {temporaryTraversal.TaskName} | Priority: {temporaryTraversal.Priority} | Due: {temporaryTraversal.DueDate.ToShortDateString()}");
                temporaryTraversal = temporaryTraversal.Next;
            } while (temporaryTraversal != head);
        }

        // Search by priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            TaskNode temporaryTraversal = head;
            bool found = false;

            do
            {
                if (temporaryTraversal.Priority == priority)
                {
                    Console.WriteLine($"{temporaryTraversal.TaskId} | {temporaryTraversal.TaskName} | Due: {temporaryTraversal.DueDate.ToShortDateString()}");
                    found = true;
                }
                temporaryTraversal = temporaryTraversal.Next;
            } while (temporaryTraversal != head);

            if (!found)
                Console.WriteLine("No tasks found with given priority");
        }
    }

    class TaskSchedular
    {
        static void Main()
        {
            TaskCircularLinkedList scheduler = new TaskCircularLinkedList();

            scheduler.AddAtEnd(1, "Design Module", 1, DateTime.Now.AddDays(2));
            scheduler.AddAtBeginning(2, "Fix Bugs", 2, DateTime.Now.AddDays(1));
            scheduler.AddAtPosition(2, 3, "Write Tests", 1, DateTime.Now.AddDays(3));

            Console.WriteLine("All Tasks:");
            scheduler.DisplayAllTasks();

            Console.WriteLine("View Next Tasks:");
            scheduler.ViewNextTask();
            scheduler.ViewNextTask();

            Console.WriteLine("Search by Priority 1:");
            scheduler.SearchByPriority(1);

            Console.WriteLine("Removing Task ID 2:");
            scheduler.RemoveByTaskId(2);

            Console.WriteLine("Final Task List:");
            scheduler.DisplayAllTasks();
        }
    }
}
