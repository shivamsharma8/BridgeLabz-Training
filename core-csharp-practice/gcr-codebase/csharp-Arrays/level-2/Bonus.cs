using System;

class Bonus{
	
	static void Main(String[] args){
		
		// Taking the total number of employees given in the question
        int totalEmployees = 10;

        // Creating arrays to store salary and years of service
        double[] salary = new double[totalEmployees];
        double[] yearsOfService = new double[totalEmployees];

        //Creating arrays to store bonus amount and new salary
        double[] bonus = new double[totalEmployees];
        double[] newSalary = new double[totalEmployees];

        //Creating variables to store total bonus,old salary and new salary
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Taking the inputs from the user of different arrays
        for (int iterator=0;iterator<totalEmployees;iterator++){
        
            salary[iterator] = double.Parse(Console.ReadLine());

            yearsOfService[iterator] = double.Parse(Console.ReadLine());

            if (salary[iterator]<=0||yearsOfService[iterator]<0){
                iterator--;   // decrement index 
                continue;
            }

            totalOldSalary+=salary[iterator];
        }

        // Calculating bonus and new salary and checking the conditions also
        for (int iterator=0;iterator<totalEmployees;iterator++){
        
            
            if (yearsOfService[iterator]>5){
                bonus[iterator]=salary[iterator]*0.05; 
            }
            else{
                bonus[iterator]=salary[iterator]*0.02;
            }

            newSalary[iterator]=salary[iterator]+bonus[iterator];

            totalBonus+=bonus[iterator];
            totalNewSalary+=newSalary[iterator];
        }

        // Displaying the results 
        Console.WriteLine(totalOldSalary);
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNewSalary);
    }
}

		