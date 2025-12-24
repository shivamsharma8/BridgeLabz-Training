using System;

class LargestAndSecond{
	static void Main(){
		//Taking the number input from user
        int number=int.Parse(Console.ReadLine());

        // Creating variable max digit and digits array
        int maxDigit=10;
        int[] digits=new int[maxDigit];

        //Creating a index variable
        int index=0;

        //Using while loop until number becomes 0
        while(number!=0){
			
            // Checking if index is equal to maxDigit
            if(index==maxDigit){
				
				maxDigit=maxDigit+10;
                int[] temp=new int[maxDigit];

               //Copying the existing digits into temporary array
                for(int iterator=0;iterator<index;iterator++){
					
                    temp[iterator]=digits[iterator];
                }

                digits=temp;
            }

            //Removing the last digit and storing it
            digits[index]=number%10;
            number=number/10;

            index++;
        }

        //Creating variables for largest and second largest
        int largest=0;
        int secondLargest=0;

        //Finding the largest and second largest digit
        for (int iterator=0;iterator<index;iterator++){
			
            if (digits[iterator]>largest){
				
                secondLargest=largest;
                largest=digits[iterator];
            }
            else if (digits[iterator]>secondLargest&&digits[iterator]!=largest){
                secondLargest=digits[iterator];
            }
        }

        //Displaying the results
        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);
	}
}