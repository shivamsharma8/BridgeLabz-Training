using System;

// Abstract LibraryItem class
abstract class LibraryItem
{
    // Properties
    public int ItemId { get; set; }
    public string Author { get; set; }

    // Abstract method
    public abstract int GetLoanDuration();

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + ItemId);
        Console.WriteLine("Author: " + Author);
    }
}

// Reservable interface
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book class
class Book : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 14; // days
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book Reserved");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

// Magazine class
class Magazine : LibraryItem
{
    public override int GetLoanDuration()
    {
        return 7; // days
    }
}

// DVD class
class DVD : LibraryItem
{
    public override int GetLoanDuration()
    {
        return 5; // days
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Array of library items
        LibraryItem[] items = new LibraryItem[3];

        items[0] = new Book();
        items[0].ItemId = 101;
        items[0].Author = "Author A";

        items[1] = new Magazine();
        items[1].ItemId = 102;
        items[1].Author = "Author B";

        items[2] = new DVD();
        items[2].ItemId = 103;
        items[2].Author = "Author C";

        // Polymorphism
        for (int i = 0; i < items.Length; i++)
        {
            items[i].GetItemDetails();
            Console.WriteLine("Loan Duration: " + items[i].GetLoanDuration() + " days");
            Console.WriteLine("--------------------");
        }
    }
}
