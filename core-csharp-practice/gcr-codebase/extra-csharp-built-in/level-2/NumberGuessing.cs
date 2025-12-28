using System;

class NumberGuessing{

    // Method to generate number
    static int GenerateNumber(){
        Random random=new Random();
        return random.Next(1,101);
    }

    // Method to check guess
    static void CheckGuess(int guess,int number){
        if(guess<number){
            Console.WriteLine("Low");
        }
        else if(guess>number){
            Console.WriteLine("High");
        }
        else{
            Console.WriteLine("Correct");
        }
    }

    static void Main(string[] args){
		
		// Taking the input from the user and pass it to the method
        int number=GenerateNumber();
        int guess=0;
		
		// Displaying the result till the guess is not equal to number
        while(guess!=number){
            guess=int.Parse(Console.ReadLine());
            CheckGuess(guess,number);
        }
    }
}
