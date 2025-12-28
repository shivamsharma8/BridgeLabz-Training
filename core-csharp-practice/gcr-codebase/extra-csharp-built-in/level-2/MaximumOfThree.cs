using System;

class MaximumOfThree{

    // Method to find maximum
    static int FindMax(int first,int second,int third){
        int max=first;

        if(second>max){
            max=second;
        }
        if(third>max){
            max=third;
        }

        return max;
    }

    static void Main(string[] args){
		
		
		// Taking the input from the user
		
        int first=int.Parse(Console.ReadLine());
        int second=int.Parse(Console.ReadLine());
        int third=int.Parse(Console.ReadLine());

		// Displaying the result
		
        int result=FindMax(first,second,third);
        Console.WriteLine(result);
    }
}
