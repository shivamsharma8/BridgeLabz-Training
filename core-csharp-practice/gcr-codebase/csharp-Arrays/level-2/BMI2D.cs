using System;

class BMI2D{
	static void Main(String[] args){
		
		// Taking the input from the user for the number of person
 
        int number=int.Parse(Console.ReadLine());

        //Creating a 2-D array to store height,weight,BMI
        double[,] personData=new double[number,3];

        // Array to store weight status
        string[] weightStatus=new string[number];

        // Taking the input for height and weight
        for(int iterator=0;iterator<number;iterator++){
			
			
            // Taking the value of height from the user and also checking if the height is positive
            while(true){
 
                personData[iterator,0]=double.Parse(Console.ReadLine());
                if(personData[iterator,0]>0)
                    break;
            }

            // Taking the value of weight and checking negative value
            while(true){
				
                personData[iterator,1]=double.Parse(Console.ReadLine());
                if(personData[iterator,1]>0)
                    break;
            }
        }

        // Calculating the value of BMI and status
        for(int iterator=0;iterator<number;iterator++)
        {
            personData[iterator,2]=personData[iterator,1]/(personData[iterator,0]*personData[iterator,0]);

            if(personData[iterator,2]<=18.4)
                weightStatus[iterator]="Underweight";
            else if(personData[iterator,2]>=18.5&&personData[iterator,2]<=24.9)
                weightStatus[iterator]="Normal";
            else if(personData[iterator,2]>=25.0&&personData[iterator,2]<=39.9)
                weightStatus[iterator]="Overweight";
            else
                weightStatus[iterator]="Obese";
        }

        // Displaying the result

        for(int iterator=0;iterator<number;iterator++){
            Console.WriteLine(personData[iterator,0]+"  "+personData[iterator,1]+"  "+personData[iterator,2]+"  "+weightStatus[iterator]);
        }
		
	}
}