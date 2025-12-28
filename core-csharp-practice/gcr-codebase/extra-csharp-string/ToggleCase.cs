using System;

class ToggleCase{

    // Method to toggle case
    static string Toggle(string text){
        string result="";
        for(int number=0;number<text.Length;number++){
            char ch=text[number];
            if(ch>='a'&&ch<='z'){
                ch=(char)(ch-32);
            }
            else if(ch>='A'&&ch<='Z'){
                ch=(char)(ch+32);
            }
            result+=ch;
        }
        return result;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the results
		
        string result=Toggle(text);
        Console.WriteLine(result);
    }
}
