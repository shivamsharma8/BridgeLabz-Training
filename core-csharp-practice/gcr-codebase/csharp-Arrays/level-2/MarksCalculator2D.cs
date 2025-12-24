using System;

class MarksCalculator2D{
	static void Main(String[] args){
		
		// Taking the number of students from the user
        int number=int.Parse(Console.ReadLine());

        // Creating a 2D array to store marks
        int[,] marks=new int[number,3];

        //Creating the arrays to store percentage and grade
        double[] percentage=new double[number];
        string[] grade=new string[number];

        // Taking the marks as input from the user
        for(int iterator=0;iterator<number;iterator++){

            for(int iterator2=0;iterator2<3;iterator2++){
				
                if(iterator2==0)
                    Console.Write("Enter Physics marks:");
                else if(iterator2==1)
                    Console.Write("Enter Chemistry marks:");
                else
                    Console.Write("Enter Maths marks:");

                marks[iterator,iterator2]=int.Parse(Console.ReadLine());

                // Checking if marks are negative, ask again
                if(marks[iterator,iterator2]<0)
                {
                    Console.WriteLine("Marks must be positive.Enter again.");
                    iterator2--;
                }
            }
        }

        // Calculating percentage and grade
        for(int iterator=0;iterator<number;iterator++)
        {
            int total=marks[iterator,0]+marks[iterator,1]+marks[iterator,2];
            percentage[iterator]=(total*100)/300.0;

            if(percentage[iterator]>=80)
                grade[iterator]="A";
            else if(percentage[iterator]>=70)
                grade[iterator]="B";
            else if(percentage[iterator]>=60)
                grade[iterator]="C";
            else if(percentage[iterator]>=50)
                grade[iterator]="D";
            else if(percentage[iterator]>=40)
                grade[iterator]="E";
            else
                grade[iterator]="R";
        }

        // Displaying the final result
     
        for(int iterator=0;iterator<number;iterator++){
			
            Console.WriteLine(marks[iterator,0]+" "+marks[iterator,1]+" "+marks[iterator,2]+" "+percentage[iterator]+" "+grade[iterator]);
        }
		
	}
}