using System;
using System.Collections.Generic;

// Represents a Student
class Student{
	
    public string Name; // Stores student name

    // Constructor to initialize student name
    public Student(string name){
		
        Name = name;
    }
}

// Represents a Professor
class Professor{
	
    public string Name; // Stores professor name

    // Constructor to initialize professor name
    public Professor(string name){
		
        Name = name;
    }

    // Professor teaches a student
    public void AssignProfessor(Student student){
		
        Console.WriteLine(Name + " teaches " + student.Name);
    }
}

// Represents a Course
class Course{
	
    public string CourseName; // Stores course name

    // Constructor to initialize course name
    public Course(string name)
    {
        CourseName = name;
    }
}

class Program{
	
    static void Main(){
		
        // Creating student, professor, and course objects
        Student s1 = new Student("Sahil");
        Professor p1 = new Professor("Dr. Sharma");
        Course c1 = new Course("Computer Science");

        // Professor teaches the student
        p1.AssignProfessor(s1);
    }
}
