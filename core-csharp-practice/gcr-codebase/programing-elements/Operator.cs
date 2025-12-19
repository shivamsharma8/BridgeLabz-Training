using System;

class Operators {
	static void Main(){
		int num1 = 10;
		int num2 = 20;
		
		// Arithmetic Operators
		
		Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));//Addition
		Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));//Subtraction
		Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));//Multiplication
		Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));//Division
		Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));//Modulus
		
		// Relational Operators
		
		Console.WriteLine(num1 + " == " + num2 + " = " + (num1 == num2));//comparison
		Console.WriteLine(num1 + " > " + num2 + " = " + (num1 > num2));//Greater Then
		Console.WriteLine(num1 + " < " + num2 + " = " + (num1 < num2));//Lesser Then
		Console.WriteLine(num1 + " != " + num2 + " = " + (num1 != num2));//Not Equals
		Console.WriteLine(num1 + " >= " + num2 + " = " + (num1 >= num2));//Greater Than Equal to
		Console.WriteLine(num1 + " <= " + num2 + " = " + (num1 <= num2));//Less Than Equal to
		
		//Logical Operators
		
		bool x = true;
		bool y = false;
		
		Console.WriteLine("x && y: " + (x && y)); //Logical AND
		Console.WriteLine("x || y: " + (x || y)); //Logical OR
		Console.WriteLine("!x: " + (!x)); //Logical NOT
		
		//Assignments Operators
		
		int a = 25;
		int b = 50;

		a += b; //Assignment 
		Console.WriteLine("a += b: " + a); //Addition Assignment
		a -= b; //Subtraction Assignment
		Console.WriteLine("a -= b: " + a);
		a *= b; //Multiplication Assignment
		Console.WriteLine("a *= b: " + a); 
		a /= b; //Division Assignment
		Console.WriteLine("a /= b: " + a);
		a %= b; //Modulus Assignment
		Console.WriteLine("a %= b: " + a);
		
		//Unary Operators

		Console.WriteLine("a: " + a);//Unary plus
		Console.WriteLine("a: " + (-a));//Unary minus
		Console.WriteLine("++a: " + ++a);// (pre-increment)
		Console.WriteLine("a++: " + a++);// (post-increment)
		Console.WriteLine("a: " + a);
		Console.WriteLine("--a: " + --a);// (pre-decrement)
		Console.WriteLine("a--: " + a--);// (post-decrement)
		Console.WriteLine("a: " + a);
		
		//Ternary Operators
		
		int max = (a > b) ? a : b;
		Console.WriteLine("Max: " + max);
		
		//is Operators
		
		Console.WriteLine("num1 is int : " + (num1 is int));//check if 'num1' is compatible with int
		Console.WriteLine("num1 is Double : " + (num1 is Double));//check if 'num1' is compatible with double
		
		
	}
}