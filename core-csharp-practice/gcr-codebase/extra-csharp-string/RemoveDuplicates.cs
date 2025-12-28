using System;

class RemoveDuplicates{

    // Method to remove duplicates
    static string Remove(string text){
        string result="";
        for(int number=0;number<text.Length;number++){
            bool found=false;
            for(int iterator=0;iterator<result.Length;iterator++){
                if(text[number]==result[iterator]){
                    found=true;
                }
            }
            if(found==false){
                result+=text[number];
            }
        }
        return result;
    }

    static void Main(string[] args){
		
		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the result
		
        string result=Remove(text);
        Console.WriteLine(result);
    }
}
