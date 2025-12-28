using System;

class TimeZones{

    static void Main(string[] args){

        // Get current UTC time
        DateTimeOffset current=DateTimeOffset.UtcNow;

        // Get time zones
        TimeZoneInfo gmt=TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist=TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst=TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Display time in different zones
        Console.WriteLine(TimeZoneInfo.ConvertTime(current,gmt));
        Console.WriteLine(TimeZoneInfo.ConvertTime(current,ist));
        Console.WriteLine(TimeZoneInfo.ConvertTime(current,pst));
    }
}
