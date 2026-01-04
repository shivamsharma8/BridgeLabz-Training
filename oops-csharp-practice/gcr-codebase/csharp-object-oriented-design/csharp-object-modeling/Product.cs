using System;
using System.Collections.Generic;

// Represents a Product
class Product{
	
    public string ProductName; // Stores product name

    // Constructor to initialize product name
    public Product(string name){
		
        ProductName = name;
    }
}

// Represents an Order
class Order{
	
    // List to store products in the order
    public List<Product> Products = new List<Product>();

    // Adds a product to the order
    public void AddProduct(Product product){
		
        Products.Add(product);
    }
}

// Represents a Customer
class Customer{
	
    public string Name; // Stores customer name

    // Constructor to initialize customer name
    public Customer(string name){
		
        Name = name;
    }

    // Customer places an order
    public void PlaceOrder(Order order){
		
        Console.WriteLine(Name + " placed an order.");
    }
}

class Program{
	
    static void Main(){
		
        // Creating a customer
        Customer c1 = new Customer("Sahil");

        // Creating a product
        Product p1 = new Product("Laptop");

        // Creating an order and adding product to it
        Order order = new Order();
        order.AddProduct(p1);

        // Customer places the order
        c1.PlaceOrder(order);
    }
}
