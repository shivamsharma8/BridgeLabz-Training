using System;

class FactorialRecursion{

    // Method to calculate factorial
    static int Factorial(int number){
        if(number==0){
            return 1;
        }
        return number*Factorial(number-1);
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        int number=int.Parse(Console.ReadLine());
		
		// Displaying the result
		
        int result=Factorial(number);
        Console.WriteLine(result);
    }
}
