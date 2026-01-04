using System;

class Person{
	
    // Common attributes
    public string Name;
    public int Age;

    // Method to display role
    public virtual void DisplayRole(){
		
        Console.WriteLine("Person in school");
    }
}

// Teacher class
class Teacher : Person{
	
    public string Subject;

    public override void DisplayRole(){
		
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}

// Student class
class Student : Person{
	
    public string Grade;

    public override void DisplayRole(){
		
        Console.WriteLine("Role: Student");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}

// Staff class
class Staff : Person{
	
    public string Department;

    public override void DisplayRole(){
		
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
    }
}

class SchoolProgram{
	
    static void Main(){
		
        Teacher teacher = new Teacher();
        teacher.Name = "Sahil";
        teacher.Age = 40;
        teacher.Subject = "Math";

        Student student = new Student();
        student.Name = "Sahil 1";
        student.Age = 15;
        student.Grade = "10th";

        Staff staff = new Staff();
        staff.Name = "Sahil 2";
        staff.Age = 45;
        staff.Department = "Administration";

        teacher.DisplayRole();
        Console.WriteLine();

        student.DisplayRole();
        Console.WriteLine();

        staff.DisplayRole();
    }
}
