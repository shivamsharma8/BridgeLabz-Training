using System;

class Employee{
	
    // Common attributes
    public string Name;
    public int Id;
    public double Salary;

    // Method to display employee details
    public virtual void DisplayDetails(){
		
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

// Manager class
class Manager : Employee{
	
    public int TeamSize;

    public override void DisplayDetails(){
		
        Console.WriteLine("Manager Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

// Developer class
class Developer : Employee{
	
    public string ProgrammingLanguage;

    public override void DisplayDetails(){
		
        Console.WriteLine("Developer Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

// Intern class
class Intern : Employee{
	
    public string Institution;

    public override void DisplayDetails(){
		
        Console.WriteLine("Intern Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Institution: " + Institution);
    }
}

class EmployeeProgram{
	
    static void Main(){
		
        // Creating Manager object
        Manager manager = new Manager();
        manager.Name = "Sahil";
        manager.Id = 101;
        manager.Salary = 80000;
        manager.TeamSize = 5;

        // Creating Developer object
        Developer developer = new Developer();
        developer.Name = "Sahil 2";
        developer.Id = 102;
        developer.Salary = 60000;
        developer.ProgrammingLanguage = "C#";

        // Creating Intern object
        Intern intern = new Intern();
        intern.Name = "Sahil 3";
        intern.Id = 103;
        intern.Salary = 15000;
        intern.Institution = "GLA College";

        // Display details
        manager.DisplayDetails();
        Console.WriteLine();

        developer.DisplayDetails();
        Console.WriteLine();

        intern.DisplayDetails();
    }
}
