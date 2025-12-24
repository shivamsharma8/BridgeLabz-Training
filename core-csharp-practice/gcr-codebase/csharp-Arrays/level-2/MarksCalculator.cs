using System;

class MarksCalculator{
	static void Main(String[] args){
		
		// Taking the total number of students from the user
    
        int number=int.Parse(Console.ReadLine());

        // Creating some arrays to store marks, percentage and grade
        int[] physics=new int[number];
        int[] chemistry=new int[number];
        int[] maths=new int[number];
        double[] percentage=new double[number];
        char[] grade=new char[number];

        // Taking the input of marks from the user
        for(int iterator=0;iterator<number;iterator++){
			
            physics[iterator]=int.Parse(Console.ReadLine());

            chemistry[iterator]=int.Parse(Console.ReadLine());

            maths[iterator]=int.Parse(Console.ReadLine());

            // If the marks are negative
            if(physics[iterator]<0||chemistry[iterator]<0||maths[iterator]<0){	
                iterator--;
            }
        }

        // Calculating the percentage and grade
        for(int iterator=0;iterator<number;iterator++){
			
            percentage[iterator]=(physics[iterator]+chemistry[iterator]+maths[iterator])*100/300;

            if(percentage[iterator]>=80)
                grade[iterator]='A';
            else if(percentage[iterator]>=70)
                grade[iterator]='B';
            else if(percentage[iterator]>=60)
                grade[iterator]='C';
            else if(percentage[iterator]>=50)
                grade[iterator]='D';
            else if(percentage[iterator]>=40)
                grade[iterator]='E';
            else
                grade[iterator]='R';
        }

        // Displaying the result
        for(int iterator=0;iterator<number;iterator++){
			
            Console.WriteLine(physics[iterator]+" "+chemistry[iterator]+" "+maths[iterator]+" "+percentage[iterator]+" "+grade[iterator]);
        }
		
	}
}