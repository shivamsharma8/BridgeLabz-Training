using System;

class ReverseNumber{
	static void Main(String[] args){
		
		//Taking the input from the user
        int number=int.Parse(Console.ReadLine());
		
		// Creating a temporary variable for the numbers
        int temporaryNumber=number;

        //Finding the count of the digits
        int count=0;
        while(temporaryNumber!=0){
			
            count++;
            temporaryNumber=temporaryNumber/10;
        }

        // Creating a array to store digits
        int[] digits=new int[count];
        int index=0;

        // Storing the digits in an array
        while(number!=0){
			
            digits[index]=number%10;
            number=number/10;
            index++;
        }

        //Storing the array elements in reverse order
        int[] reverseArray=new int[count];

        // Copying the digits into reverse array
        for(int iterator=0;iterator<count;iterator++){
			
            reverseArray[iterator]=digits[count-1-iterator];
        }

        //Displaying the result
        for(int iterator=0;iterator<count;iterator++){
			
            Console.Write(reverseArray[iterator]);
        }
	}
}