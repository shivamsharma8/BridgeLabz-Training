using System;

class DateArithmetic{

    static void Main(string[] args){

        // Take date input
        DateTime date=DateTime.Parse(Console.ReadLine());

        // Add days, months and years
        date=date.AddDays(7);
        date=date.AddMonths(1);
        date=date.AddYears(2);

        // Subtract 3 weeks
        date=date.AddDays(-21);

        // Display result
        Console.WriteLine(date);
    }
}
