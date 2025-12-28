using System;

class BasicCalculator{

    // Addition Method
    static double Add(double a,double b){
        return a+b;
    }

    // Subtraction Method
    static double Subtract(double a,double b){
        return a-b;
    }

    // Multiplication Method
    static double Multiply(double a,double b){
        return a*b;
    }

    // Division Method
    static double Divide(double a,double b){
        return a/b;
    }

    static void Main(string[] args){


        // Taking the input from the user 
		
        double first=double.Parse(Console.ReadLine());
        double second=double.Parse(Console.ReadLine());
        int choice=int.Parse(Console.ReadLine());

		// Displaying the result according to the choice from the user
        if(choice==1){
            Console.WriteLine(Add(first,second));
        }
        else if(choice==2){
            Console.WriteLine(Subtract(first,second));
        }
        else if(choice==3){
            Console.WriteLine(Multiply(first,second));
        }
        else{
            Console.WriteLine(Divide(first,second));
        }
    }
}
