using System;

class ReverseString{

    // Method to reverse string
    static string Reverse(string text){
        string result="";
        for(int number=text.Length-1;number>=0;number--){
            result+=text[number];
        }
        return result;
    }

    static void Main(string[] args){
		
		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the results
		
        string result=Reverse(text);
        Console.WriteLine(result);
    }
}
