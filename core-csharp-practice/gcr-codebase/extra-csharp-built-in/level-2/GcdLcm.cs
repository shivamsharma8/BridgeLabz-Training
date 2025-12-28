using System;

class GcdLcm{

    // Method to find GCD
    static int Gcd(int first,int second){
        while(second!=0){
            int temp=second;
            second=first%second;
            first=temp;
        }
        return first;
    }

    // Method to find LCM
    static int Lcm(int first,int second){
        return (first*second)/Gcd(first,second);
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        int first=int.Parse(Console.ReadLine());
        int second=int.Parse(Console.ReadLine());

		// Displaying the result
		
        Console.WriteLine(Gcd(first,second));
        Console.WriteLine(Lcm(first,second));
    }
}
