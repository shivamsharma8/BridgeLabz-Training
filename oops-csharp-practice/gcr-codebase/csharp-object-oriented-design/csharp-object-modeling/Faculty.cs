using System;
using System.Collections.Generic;

// Represents a Faculty member
class Faculty{
	
    public string Name;  // Stores faculty name

    // Constructor to initialize faculty name
    public Faculty(string name){
		
        Name = name;
    }
}

// Represents a Department
class Department{
	
    public string DepartmentName;  // Stores department name

    // Constructor to initialize department name
    public Department(string name){
		
        DepartmentName = name;
    }
}

// Represents a University
class University{
	
    public string UniversityName;  // Stores university name

    // List to store departments (composition)
    public List<Department> Departments = new List<Department>();

    // List to store faculty members (association)
    public List<Faculty> Faculties = new List<Faculty>();

    // Constructor to initialize university name
    public University(string name){
		
        UniversityName = name;
    }

    // Adds a department to the university
    public void AddDepartment(Department dept){
		
        Departments.Add(dept);
    }

    // Adds a faculty member to the university
    public void AddFaculty(Faculty faculty){
		
        Faculties.Add(faculty);
    }

    // Deletes university-related data
    public void DeleteUniversity(){
		
        Departments.Clear(); // Departments are removed (composition)
        Console.WriteLine("University deleted. All departments removed.");
    }
}

class Program{
	
    static void Main(String[] args){
		
        // Creating a university object
        University uni = new University("ABC University");

        // Creating department and faculty objects
        Department d1 = new Department("CSE");
        Faculty f1 = new Faculty("Dr. Sharma");

        // Adding department and faculty to university
        uni.AddDepartment(d1);
        uni.AddFaculty(f1);

        // Deleting university (clears departments)
        uni.DeleteUniversity();

        // Faculty still exists because it's not part of composition
        Console.WriteLine("Faculty still exists: " + f1.Name);
    }
}
