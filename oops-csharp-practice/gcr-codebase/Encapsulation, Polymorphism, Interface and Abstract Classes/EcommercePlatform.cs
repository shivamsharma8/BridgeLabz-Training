using System;

// Abstract Product class
abstract class Product
{
    private int productId;
    private string productName;
    private double price;

    public void SetProduct(int id, string name, double value)
    {
        productId = id;
        productName = name;
        price = value;
    }

    public double GetPrice()
    {
        return price;
    }

    // Abstract method
    public abstract double CalculateDiscount();
}

// Interface for tax
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics product
class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return GetPrice() * 0.10;
    }

    public double CalculateTax()
    {
        return GetPrice() * 0.18;
    }

    public string GetTaxDetails()
    {
        return "Electronics GST 18%";
    }
}

// Clothing product
class Clothing : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return GetPrice() * 0.20;
    }

    public double CalculateTax()
    {
        return GetPrice() * 0.05;
    }

    public string GetTaxDetails()
    {
        return "Clothing GST 5%";
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Using array
        Product[] products = new Product[2];

        products[0] = new Electronics();
        products[0].SetProduct(1, "Laptop", 50000);

        products[1] = new Clothing();
        products[1].SetProduct(2, "Shirt", 1000);

        for (int i = 0; i < products.Length; i++)
        {
            ITaxable tax = (ITaxable)products[i];

            double finalPrice = products[i].GetPrice()
                                + tax.CalculateTax()
                                - products[i].CalculateDiscount();

            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("--------------------");
        }
    }
}
