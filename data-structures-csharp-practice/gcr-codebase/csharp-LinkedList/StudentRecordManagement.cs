using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    public class StudentNode
    {
        public int RollNumber;
        public string NameOfStudent;
        public int AgeOfStudent;
        public string GradeOfStudent;
        public StudentNode Next;
        public StudentNode(int rollNumber, string nameOfStudent, int ageOfStudent, string gradeOfStudent)
        {
            RollNumber = rollNumber;
            NameOfStudent = nameOfStudent;
            AgeOfStudent = ageOfStudent;
            GradeOfStudent = gradeOfStudent;
            Next = null;
        }
    }
    class StudentLinkedList
    {
        private StudentNode head;
        public void AddAtBeginning(int rollNumber, string nameOfStudent, int ageOfStudent, string gradeOfStudent)
        {
            StudentNode newNode = new StudentNode(rollNumber, nameOfStudent, ageOfStudent, gradeOfStudent);
            newNode.Next = head;
            head = newNode;
        }
        public void AddAtEnding(int rollNumber, string nameOfStudent, int ageOfStudent, string gradeOfStudent)
        {
            StudentNode newNode = new StudentNode(rollNumber, nameOfStudent, ageOfStudent, gradeOfStudent);
            if (head == null)
            {
                head = newNode;
                return;
            }
            StudentNode TemporaryTraversal = head;
            while (TemporaryTraversal.Next != null)//until we reach the end
            {
                TemporaryTraversal = TemporaryTraversal.Next;
            }
            TemporaryTraversal.Next = newNode;
            
        }
        public void AddAtSpecificPosition(int position, int rollNumber, string nameOfStudent, int ageOfStudent, string gradeOfStudent)
        {
            if (position <= 1)
            {
                AddAtBeginning(rollNumber, nameOfStudent, ageOfStudent, gradeOfStudent);
                return;
            }
            StudentNode newNode = new StudentNode(rollNumber, nameOfStudent, ageOfStudent, gradeOfStudent);
            StudentNode temporayTraversal = head;
            for(int i = 1; i < position - 1 && temporayTraversal != null; i++)
            {
                temporayTraversal= temporayTraversal.Next;
            }
            if (temporayTraversal == null){
                Console.WriteLine("Invalid position.");
                return;
            }
            newNode.Next = temporayTraversal.Next;
            temporayTraversal.Next = newNode;
        }
        public void DeleteByRollNumber(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("Student list is empty");
                return;
            }
            if(head.RollNumber == rollNumber)
            {
                head = head.Next;
                Console.WriteLine("Student record deleted.");
                return;
            }
            StudentNode TemporaryTraversal = head;
            while (TemporaryTraversal.Next != null && TemporaryTraversal.Next.RollNumber != rollNumber) { 
            TemporaryTraversal = TemporaryTraversal.Next;
            }
            if (TemporaryTraversal.Next == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                TemporaryTraversal.Next = TemporaryTraversal.Next.Next;
                Console.WriteLine("Student record deleted");
            }
        }
        public void SearchByRollNumber(int rollNumber)
        {
            StudentNode TemporaryTraversal = head;
            while (TemporaryTraversal != null)
            {
                if(TemporaryTraversal.RollNumber == rollNumber)
                {
                    Console.WriteLine("Found: "+TemporaryTraversal.RollNumber+"|"+TemporaryTraversal.AgeOfStudent+"|"+TemporaryTraversal.GradeOfStudent+"|");
                    return;
                }
                TemporaryTraversal=TemporaryTraversal.Next;
            }
            Console.WriteLine("Student record not found");
        }
        public void UpdateGradeOfStudent(int rollNumber, string newGradeOfStudent)
        {
            StudentNode TemporaryTraversal = head;
            while (TemporaryTraversal != null)
            {
                if (TemporaryTraversal.RollNumber == rollNumber)
                {
                    TemporaryTraversal.GradeOfStudent = newGradeOfStudent;
                    Console.WriteLine("grade updated successfully. ");
                    return;
                }
                TemporaryTraversal = TemporaryTraversal.Next;
            }
            Console.WriteLine("Student not found.");
        }
        public void DisplayAllDetailsOfStudents()
        {
            if(head == null)
            {
                Console.WriteLine("Student records are empty");
                return;
            }
            StudentNode TemporaryTraversal = head;
            while (TemporaryTraversal != null)
            {   
                 Console.WriteLine("Found: " + TemporaryTraversal.RollNumber + "|" + TemporaryTraversal.AgeOfStudent + "|" + TemporaryTraversal.GradeOfStudent + "|"+TemporaryTraversal.NameOfStudent+" .");
                TemporaryTraversal = TemporaryTraversal.Next;
            }

        }
    }
    class StudentRecordManagement
    {
        static void Main()
        {
            StudentLinkedList listofStudent = new StudentLinkedList();

            listofStudent.AddAtEnding(101, "Amir", 28, "A+");
            listofStudent.AddAtBeginning(102, "Rama", 19, "C");
            listofStudent.AddAtSpecificPosition(2, 103, "Raju", 20, "O");

            Console.WriteLine("All Students:");
            listofStudent.DisplayAllDetailsOfStudents();

            Console.WriteLine("Searching Roll Number 103:");
            listofStudent.SearchByRollNumber(103);

            Console.WriteLine("Updating Grade of Roll No 102:");
            listofStudent.UpdateGradeOfStudent(102, "A+");

            Console.WriteLine("Deleting Roll Number 101:");
            listofStudent.DeleteByRollNumber(101);

            Console.WriteLine("Final Student List:");
            listofStudent.DisplayAllDetailsOfStudents();
        }
    }
}
