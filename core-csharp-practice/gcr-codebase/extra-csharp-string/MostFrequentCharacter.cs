using System;

class MostFrequentCharacter{

    // Method to find most frequent character
    static char FindMostFrequent(string text){
        int maxCount=0;
        char result=' ';

        for(int number=0;number<text.Length;number++){
            int count=0;
            for(int iterator=0;iterator<text.Length;iterator++){
                if(text[number]==text[iterator]){
                    count++;
                }
            }
            if(count>maxCount){
                maxCount=count;
                result=text[number];
            }
        }
        return result;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the results
		
        char result=FindMostFrequent(text);
        Console.WriteLine(result);
    }
}
