using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.access_modifiers
{
    public class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        public Student(int rollNumber, string name, double cgpa)
        {
           this.rollNumber = rollNumber;
           this.name = name;
           this.cgpa = cgpa;
        }
        public double GetCgpa()
        {
            return cgpa;
        }
        public void UpdateCgpa(double newCgpa)
        {
            if(newCgpa>=0.0 && newCgpa <= 10.0)
            {
                cgpa = newCgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA");
            }
        }
    }
    public class PostGraduateStudent : Student
    {
        private string courseName;

        public PostGraduateStudent(int rollNumber, string name, double cgpa, string courseName) : base(rollNumber, name, cgpa)
        {
            this.courseName = courseName;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll number " + rollNumber);
            Console.WriteLine("name " + name);
            Console.WriteLine("cgpa " + GetCgpa());
            Console.WriteLine("Course Name " + courseName);
        }
    }
    public class UniversityManagementSystem
    {
        static void Main(string[] args)
        {
            PostGraduateStudent postGraduateStudent1 = new PostGraduateStudent(101, "Anmol", 8.6,"B.Tech");
            postGraduateStudent1.DisplayStudentDetails();
            postGraduateStudent1.UpdateCgpa(9.2);
            Console.WriteLine("Update Cgpa "+postGraduateStudent1.GetCgpa());
        }
    }
}
