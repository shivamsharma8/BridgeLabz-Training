using System;

// Abstract FoodItem class
abstract class FoodItem
{
    // Properties
    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + ItemName);
        Console.WriteLine("Quantity: " + Quantity);
    }
}

// Discount interface
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Veg Item class
class VegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount 10%";
    }
}

// Non-Veg Item class
class NonVegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + 50; // extra charge
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount 5%";
    }
}

// Main class
class Program
{
    static void Main()
    {
        FoodItem[] foodItems = new FoodItem[2];

        foodItems[0] = new VegItem();
        foodItems[0].ItemName = "Paneer";
        foodItems[0].Price = 200;
        foodItems[0].Quantity = 2;

        foodItems[1] = new NonVegItem();
        foodItems[1].ItemName = "Chicken";
        foodItems[1].Price = 300;
        foodItems[1].Quantity = 1;

        for (int i = 0; i < foodItems.Length; i++)
        {
            IDiscountable discount = (IDiscountable)foodItems[i];

            double finalPrice = foodItems[i].CalculateTotalPrice()
                              - discount.ApplyDiscount();

            foodItems[i].GetItemDetails();
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("--------------------");
        }
    }
}
