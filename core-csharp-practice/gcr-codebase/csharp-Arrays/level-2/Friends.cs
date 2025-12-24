using System;

class Friends{
	static void Main(String[] args){
		
		
		//Creating an array with the names of the friends
		string[] names={"Amar","Akbar","Anthony"};
		
		// Creating two arrays of age and height
		int[] age=new int[3];
        double[] height=new double[3];

        // Taking input from the user of the two arrays one by one
        for (int iterator=0;iterator<3;iterator++){
			
            Console.WriteLine(names[iterator]);

            age[iterator] = int.Parse(Console.ReadLine());

            height[iterator] = double.Parse(Console.ReadLine());
        }

        // Creating variables youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        // Finding the youngest and tallest
        for (int iterator=1;iterator<3;iterator++){
			
            if (age[iterator]<age[youngestIndex]){
				
                youngestIndex = iterator;
            }

            if (height[iterator] > height[tallestIndex]){
				
                tallestIndex = iterator;
            }
        }

        // Displaying the results
        Console.WriteLine(names[youngestIndex]);
        Console.WriteLine(names[tallestIndex]);
		
	}
}