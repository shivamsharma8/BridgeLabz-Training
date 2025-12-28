using System;

class SubstringCount{

    // Method to count substring
    static int CountSubstring(string text,string sub){
        int count=0;

        for(int number=0;number<=text.Length-sub.Length;number++){
            int match=0;
            for(int iterator=0;iterator<sub.Length;iterator++){
                if(text[number+iterator]==sub[iterator]){
                    match++;
                }
            }
            if(match==sub.Length){
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args){

		// Taking the input of string and substring from the user
        string text=Console.ReadLine();
        string sub=Console.ReadLine();

		// Displaying the results
        int result=CountSubstring(text,sub);
        Console.WriteLine(result);
    }
}
