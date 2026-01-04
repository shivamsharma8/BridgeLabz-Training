using System;

class Book{
	
    // Base class attributes
    public string Title;
    public int PublicationYear;

    public void DisplayInfo(){
		
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

class Author : Book{
	
    public string Name;
    public string Bio;

    public void DisplayAuthorInfo(){
		
        DisplayInfo(); // Calling base class method
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

class LibraryProgram{
	
    static void Main(){
		
        Author author = new Author();
        author.Title = "C# Basics";
        author.PublicationYear = 2023;
        author.Name = "Sahil";
        author.Bio = "Software Developer and Trainer";

        author.DisplayAuthorInfo();
    }
}
