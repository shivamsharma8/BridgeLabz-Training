using System;

class ReplaceWord{

    // Method to replace word
    static string Replace(string text,string oldWord,string newWord){
        string result="";
        string word="";

        for(int number=0;number<text.Length;number++){
            if(text[number]!=' '){
                word+=text[number];
            }
            else{
                if(word==oldWord){
                    result+=newWord;
                }
                else{
                    result+=word;
                }
                result+=" ";
                word="";
            }
        }

        if(word==oldWord){
            result+=newWord;
        }
        else{
            result+=word;
        }

        return result;
    }

    static void Main(string[] args){


		// Taking the input from the user
        string text=Console.ReadLine();
        string oldWord=Console.ReadLine();
        string newWord=Console.ReadLine();

		// Displaying the results
        string result=Replace(text,oldWord,newWord);
        Console.WriteLine(result);
    }
}
