using System;
using System.Collections.Generic;

// Course class
class Course{
	
    public string Name;
    public List<Student> Students = new List<Student>(); // Students enrolled

    public Course(string name){
		
        Name = name;
    }

    public void ShowStudents(){
		
        Console.WriteLine("Students in "+Name);
        foreach (var s in Students)
            Console.WriteLine(s.Name);
    }
}

// Student class
class Student{
	
    public string Name;
    public List<Course> Courses = new List<Course>(); // Courses enrolled

    public Student(string name){
		
        Name = name;
    }

    public void Enroll(Course course){
		
        Courses.Add(course);        // Add course to student
        course.Students.Add(this);  // Add student to course
    }

    public void ShowCourses(){
		
        Console.WriteLine(Name+ " is enrolled in ");
        foreach (var c in Courses)
            Console.WriteLine(c.Name);
    }
}

// School class (Aggregation)
class School{
	
    public string Name;
    public List<Student> Students = new List<Student>();

    public School(string name){
		
        Name = name;
    }

    public void AddStudent(Student s){
		
        Students.Add(s);
    }

    public void ShowStudents(){
		
        Console.WriteLine("Students in "+Name);
        foreach (var s in Students)
            Console.WriteLine(s.Name);
    }
}

// Main Program
class Program{
	
    static void Main(){
		
        // Create school, students, courses
        School school = new School("ABC High School");
        Student s1 = new Student("Sahil 1");
        Student s2 = new Student("Sahil 2");

        Course c1 = new Course("Math");
        Course c2 = new Course("Science");

        // Add students to school
        school.AddStudent(s1);
        school.AddStudent(s2);

        // Enroll students in courses
        s1.Enroll(c1);
        s1.Enroll(c2);
        s2.Enroll(c1);

        // Display
        school.ShowStudents();
        s1.ShowCourses();
        s2.ShowCourses();
        c1.ShowStudents();
        c2.ShowStudents();
    }
}
