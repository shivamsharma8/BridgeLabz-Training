using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class Student
    {
        public static string UniversityName = "Global University";
        private static int totalStudents = 0;
        public readonly int RollNumber;
        public string Name;
        public char Grade;
        public Student(string Name, int RollNumber, char Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students Enrolled: " + totalStudents);
        }

        public void DisplayStudentDetails(object student)
        {
            if (student is Student)
            {
                Console.WriteLine("University Name : " + UniversityName);
                Console.WriteLine("Student Name    : " + Name);
                Console.WriteLine("Roll Number     : " + RollNumber);
                Console.WriteLine("Grade           : " + Grade);
            }
            else
            {
                Console.WriteLine("Invalid student object");
            }
        }

        public void UpdateGrade(object student, char newGrade)
        {
            if (student is Student)
            {
                Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Grade update failed. Invalid student object.");
            }
        }
    }
    class UniversityStudentManagement
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Amit", 101, 'A');
            Student student2 = new Student("Raghav", 102, 'B');

            student1.DisplayStudentDetails(student1);
            Console.WriteLine();

            student2.DisplayStudentDetails(student2);
            Console.WriteLine();

            student1.UpdateGrade(student1, 'A');
            student1.DisplayStudentDetails(student1);
            Console.WriteLine();

            Student.DisplayTotalStudents();
        }
    }
}
