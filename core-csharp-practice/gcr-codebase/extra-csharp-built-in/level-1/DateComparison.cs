using System;

class DateComparison{

    static void Main(string[] args){

        // Take two dates
        DateTime first=DateTime.Parse(Console.ReadLine());
        DateTime second=DateTime.Parse(Console.ReadLine());

        // Compare dates
        int result=DateTime.Compare(first,second);

        if(result<0){
            Console.WriteLine("First date is before second date");
        }
        else if(result>0){
            Console.WriteLine("First date is after second date");
        }
        else{
            Console.WriteLine("Both dates are equal");
        }
    }
}
