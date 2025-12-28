using System;

class LongestWord{

    // Method to find longest word
    static string FindLongest(string text){
        string word="";
        string longest="";

        for(int number=0;number<text.Length;number++){
            if(text[number]!=' '){
                word+=text[number];
            }
            else{
                if(word.Length>longest.Length){
                    longest=word;
                }
                word="";
            }
        }

        if(word.Length>longest.Length){
            longest=word;
        }

        return longest;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the results
		
        string result=FindLongest(text);
        Console.WriteLine(result);
    }
}
