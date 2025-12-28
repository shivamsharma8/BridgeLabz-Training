using System;

class AnagramCheck{

    // Method to check anagram
    static bool IsAnagram(string first,string second){
        if(first.Length!=second.Length){
            return false;
        }

        int[] count1=new int[256]; // here taking the pre made assumptions
        int[] count2=new int[256]; // here taking the pre made assumptions

        for(int number=0;number<first.Length;number++){
            count1[first[number]]++;
            count2[second[number]]++;
        }

        for(int number=0;number<256;number++){
            if(count1[number]!=count2[number]){
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        string first=Console.ReadLine();
        string second=Console.ReadLine();
		
		// DIsplaying the result
		
        bool result=IsAnagram(first,second);
        Console.WriteLine(result);
    }
}
