using System;

class VowelsAndConsonants{
	
	// Method for vowels counting
	static int Vowels(string input){
		int vowelCount=0;
		for(int iterator=0;iterator<input.Length;iterator++){
			if(input[iterator]=='a'||input[iterator]=='e'||input[iterator]=='i'||input[iterator]=='o'||input[iterator]=='u'){
				vowelCount++;
			}
		}
		return vowelCount;
	}
	
	// Method for consonants counting
	static int Consonants(String input){
		int consonantCount=0;
		for(int iterator=0;iterator<input.Length;iterator++){
			if(input[iterator]!='a'&&input[iterator]!='e'&&input[iterator]!='i'&&input[iterator]!='o'&&input[iterator]!='u'){
				consonantCount++;
			}
		}
		return consonantCount;
	}
	
	static void Main(String[] args){
		
		// Taking the string from the user
		string user=Console.ReadLine();
		
		// Giving the values to the functions and displaying the result
		Console.WriteLine("Vowels are: "+Vowels(user));
		Console.WriteLine("Consonants are: "+Consonants(user));
		
	}
}