
using System;
using System.Collections.Generic; // Needed for List<T>

class Employee{
	
    // Public variable to store employee name
    public string Name;

    // Constructor to initialize employee
    public Employee(string name){
		
        Name = name;
    }
}

class Department{
	
    // Public variable to store department name
    public string DeptName;

    // List to store employees in this department
    public List<Employee> Employees = new List<Employee>();

    // Constructor to initialize department
    public Department(string name){
		
        DeptName = name;
    }

    // Method to add an employee to this department
    public void AddEmployee(Employee e){
		
        Employees.Add(e);
    }
}

class Company{
	
    // Public variable to store company name
    public string CompanyName;

    // List to store all departments in the company
    public List<Department> Departments = new List<Department>();

    // Constructor to initialize company
    public Company(string name){
		
        CompanyName = name;
    }

    // Method to add a department to the company
    public void AddDepartment(Department d){
		
        Departments.Add(d);
    }

    // Method to display company details
    public void ShowCompanyDetails(){
		
        Console.WriteLine("Company: " + CompanyName);
        foreach(var dept in Departments){
			
            Console.WriteLine(" Department: " + dept.DeptName);
            foreach(var emp in dept.Employees)
                Console.WriteLine("  Employee: " + emp.Name);
        }
    }
}

class Program{
	
    static void Main(){
		
        // Creating employee objects
        Employee e1 = new Employee("Sahil");
        Employee e2 = new Employee("Sahil 2");

        // Creating department and adding employees
        Department d1 = new Department("HR");
        d1.AddEmployee(e1);
        d1.AddEmployee(e2);

        // Creating company and adding department
        Company comp = new Company("TechCorp");
        comp.AddDepartment(d1);

        // Display company details
        comp.ShowCompanyDetails();
    }
}



// Composition: Employee and Department are part of Company lifecycle.
