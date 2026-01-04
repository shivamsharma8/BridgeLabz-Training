using System;

class Animal{
	
    // Common properties
    public string Name;
    public int Age;

    // Method to make sound
    public virtual void MakeSound(){
		
        Console.WriteLine("Animal makes a sound.");
    }
}

// Dog class inherits Animal
class Dog : Animal{
	
    public override void MakeSound(){
		
        Console.WriteLine("Dog barks.");
    }
}

// Cat class inherits Animal
class Cat : Animal{
	
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

// Bird class inherits Animal
class Bird : Animal{
	
    public override void MakeSound(){
		
        Console.WriteLine("Bird chirps.");
    }
}

class AnimalProgram{
	
    static void Main(){
		
        // Creating objects of different subclasses
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal bird = new Bird();

        // Calling MakeSound() method
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}
