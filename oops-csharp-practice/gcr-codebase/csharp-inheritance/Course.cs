using System;

class Course{
	
    // Base class attributes
    public string CourseName;
    public int Duration; // in hours
}

class OnlineCourse : Course{
	
    public string Platform;
    public bool IsRecorded;
}

class PaidOnlineCourse : OnlineCourse{
	
    public double Fee;
    public double Discount;
}

class CourseProgram{
	
    static void Main(){
		
        PaidOnlineCourse course = new PaidOnlineCourse();

        course.CourseName = "C# Programming";
        course.Duration = 40;
        course.Platform = "Bridge-Labz";
        course.IsRecorded = true;
        course.Fee = 4999;
        course.Discount = 1000;

        Console.WriteLine("Course Name: " + course.CourseName);
        Console.WriteLine("Duration: " + course.Duration + " hours");
        Console.WriteLine("Platform: " + course.Platform);
        Console.WriteLine("Recorded: " + course.IsRecorded);
        Console.WriteLine("Fee: " + course.Fee);
        Console.WriteLine("Discount: " + course.Discount);
    }
}
