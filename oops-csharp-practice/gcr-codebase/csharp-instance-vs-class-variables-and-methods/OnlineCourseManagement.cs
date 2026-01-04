using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.instance
{
    public class Course
    {
        private string courseName;
        private int duration;
        private double fee;
        private static string instituteName = "Initial Name";

        public Course(string  courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Institute Name : " + instituteName);
            Console.WriteLine("Course Name    : " + courseName);
            Console.WriteLine("Duration       : " + duration + " months");
            Console.WriteLine("Course Fee     : ₹" + fee);
            Console.WriteLine();
        }
        public static void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }
        public static void Main(string[] args)
        {
            Course course1 = new Course("C#",5,20000);
            course1.DisplayCourseDetails();
            Course course2 = new Course("Java", 5, 30000);
            course2.DisplayCourseDetails();
            Console.WriteLine("Updating Institute Name");
            Course.UpdateInstituteName("BridgeLabz Training");
            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();
        }
    }
}
