using System;

class DigitFrequency{
	
	static void Main(String[] args){
		
		// Taking the input number from the user
        int number=int.Parse(Console.ReadLine());

		// Creating variable for temporary and count
        int temporary=number;
        int count=0;

        // Finding the number of digits
        while(temporary>0){
			
            count++;
            temporary=temporary/10;
        }

        // Creating an array to store digits
        int[] digits=new int[count];

        temporary=number;

        // Storing the digits in an array
        for(int iterator=0;iterator<count;iterator++){
			
            digits[iterator]=temporary%10;
            temporary=temporary/10;
        }

        // Finding the frequency array for digits 0 to 9
        int[] frequency=new int[10];

        // Finding the frequency of each digit
        for(int iterator=0;iterator<count;iterator++){
			
            frequency[digits[iterator]]++;
        }

        // Displaying the results frequency of each digit
        for(int iterator=0;iterator<10;iterator++){
			
            if(frequency[iterator]>0){
				
                Console.WriteLine("Digit "+iterator+" occurs "+frequency[iterator]+" times");
            }
        }
		
	}
}