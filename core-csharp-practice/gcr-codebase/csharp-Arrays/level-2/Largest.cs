using System;

class Largest{

	static void Main(String[] args){
		
		// Taking the number input from user
        int number = int.Parse(Console.ReadLine());

        // Creating variable maxdigit and array of digits
        int maxDigit = 10;
        int[] digits = new int[maxDigit];

        // Creating a index variable
        int index = 0;

        // Using while loop until number becomes 0
        while(number!=0){
			
            if(index==maxDigit){
				
                break;
            }

            //Removing the last digit and storing it in the array
			
            digits[index]=number%10;
            number=number/10;

            index++;
        }

        //Creating variables for largest and second largest
        int largest = 0;
        int secondLargest = 0;

        //Finding the largest and second largest
        for(int iterator=0;iterator<index;iterator++){
            if (digits[iterator]>largest){
				
                secondLargest=largest;
                largest=digits[iterator];
            }
            else if(digits[iterator]>secondLargest&&digits[iterator]!=largest){
                secondLargest = digits[iterator];
            }
        }

        //Displaying the results
        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);
		
	}

}