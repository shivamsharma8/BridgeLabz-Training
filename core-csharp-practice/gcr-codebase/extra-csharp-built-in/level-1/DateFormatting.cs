using System;

class DateFormatting{

    static void Main(string[] args){

        // Get current date
        DateTime date=DateTime.Now;

        // Display in different formats
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("yyyy-MM-dd"));
        Console.WriteLine(date.ToString("ddd, MMM dd, yyyy"));
    }
}
