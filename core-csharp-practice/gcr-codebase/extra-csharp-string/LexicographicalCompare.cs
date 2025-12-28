using System;

class LexicographicalCompare{

    // Method to compare strings
    static int CompareStrings(string first,string second){
        int length=first.Length<second.Length?first.Length:second.Length;

        for(int number=0;number<length;number++){
            if(first[number]<second[number]){
                return -1;
            }
            else if(first[number]>second[number]){
                return 1;
            }
        }

        if(first.Length<second.Length){
            return -1;
        }
        else if(first.Length>second.Length){
            return 1;
        }

        return 0;
    }

    static void Main(string[] args){
	
		// Taking the input from the user
        string first=Console.ReadLine();
        string second=Console.ReadLine();
		
		// Displaying the results
        int result=CompareStrings(first,second);

        if(result<0){
            Console.WriteLine(first+" comes before "+second+" in lexicographical order");
        }
        else if(result>0){
            Console.WriteLine(first+" comes after "+second+" in lexicographical order");
        }
        else{
            Console.WriteLine("Both strings are equal");
        }
    }
}
