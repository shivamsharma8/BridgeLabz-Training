using System;

class RemoveSpecificCharacter{

    // Method to remove character
    static string RemoveCharacter(string text,char remove){
        string result="";
        for(int number=0;number<text.Length;number++){
            if(text[number]!=remove){
                result+=text[number];
            }
        }
        return result;
    }

    static void Main(string[] args){

		// Taking the inputs from the user
        string text=Console.ReadLine();
        char remove=Console.ReadLine()[0];
		
		// Displaying the results
        string result=RemoveCharacter(text,remove);
        Console.WriteLine(result);
    }
}
