using System;

// Interface
interface IWorker{
	
    void PerformDuties();
}

// Base class
class Person{
	
    public string Name;
    public int Id;
}

// Chef class
class Chef : Person, IWorker{
	
    public void PerformDuties(){
		
        Console.WriteLine("Chef is cooking food.");
    }
}

// Waiter class
class Waiter : Person, IWorker{
	
    public void PerformDuties(){
		
        Console.WriteLine("Waiter is serving food.");
    }
}

class RestaurantProgram{
	
    static void Main(){
		
        Chef chef = new Chef();
        chef.Name = "Sahil";
        chef.Id = 101;

        Waiter waiter = new Waiter();
        waiter.Name = "Sahil 2";
        waiter.Id = 102;

        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
