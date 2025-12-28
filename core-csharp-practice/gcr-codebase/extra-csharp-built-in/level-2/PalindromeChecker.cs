using System;

class PalindromeChecker{

    // Method to check palindrome
    static bool IsPalindrome(string text){
        int start=0;
        int end=text.Length-1;

        while(start<end){
            if(text[start]!=text[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

    static void Main(string[] args){
		
		// Taking the input from the user
		
        string text=Console.ReadLine();
		
		// Displaying the results
		
        bool result=IsPalindrome(text);
        Console.WriteLine(result);
    }
}
