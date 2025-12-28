using System;

class FibonacciSeries{

    // Method to generate fibonacci
    static void GenerateFibonacci(int count){
        int first=0;
        int second=1;

        for(int number=0;number<count;number++){
            Console.WriteLine(first);
            int next=first+second;
            first=second;
            second=next;
        }
    }

    static void Main(string[] args){
		
		// Taking the input from the user
		
        int count=int.Parse(Console.ReadLine());
		
		// Displaying the result
		
        GenerateFibonacci(count);
    }
}
