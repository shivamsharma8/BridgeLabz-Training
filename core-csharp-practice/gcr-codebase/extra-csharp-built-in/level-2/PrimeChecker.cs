using System;

class PrimeChecker{

    // Method to check prime
    static bool IsPrime(int number){
        if(number<=1){
            return false;
        }

        for(int iterator=2;iterator<number;iterator++){
            if(number%iterator==0){
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args){
		
		//Taking the input from the user
		
        int number=int.Parse(Console.ReadLine());
		
		// Displaying the results
		
        bool result=IsPrime(number);
        Console.WriteLine(result);
    }
}
