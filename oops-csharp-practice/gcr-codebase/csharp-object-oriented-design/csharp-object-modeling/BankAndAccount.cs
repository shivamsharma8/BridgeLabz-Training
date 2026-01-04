using System;
using System.Collections.Generic; // Required for List<T>

class Customer {
	
    // Public variable to store customer name
    public string Name;

    // Constructor to initialize customer
    public Customer(string name) {
		
        Name = name;
    }
}

class Bank{
	
    // Public variable to store bank name
    public string BankName;

    // List to store multiple customers
    public List<Customer> Customers = new List<Customer>();

    // Constructor to initialize bank
    public Bank(string name){
		
        BankName = name;
    }

    // Method to add a customer to the bank
    public void AddCustomer(Customer c){
		
        Customers.Add(c);
    }

    // Method to display all customers of the bank
    public void ShowCustomers(){
		
        foreach(var c in Customers)
            Console.WriteLine(c.Name);
    }
}

class Program{
	
    static void Main(){
		
        // Creating customer objects
        Customer c1 = new Customer("Alice");
        Customer c2 = new Customer("Bob");

        // Creating bank object
        Bank bank = new Bank("HDFC");

        // Adding customers to the bank
        bank.AddCustomer(c1);
        bank.AddCustomer(c2);

        // Displaying all customers
        bank.ShowCustomers();
    }
}


// Association: Customer can exist without Bank.