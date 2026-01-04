using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.instance
{
    public class Product
    {
        private string productName;
        private double price;
        private static int totalProducts =0;

        public Product(string name, double amount)
        {
            this.productName = name;
            this.price = amount;
            totalProducts++;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Price        : " + price);
            Console.WriteLine();
        }
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total product details"+totalProducts);
        }
        static void Main(string[] args)
        {
            Product product1 = new Product("Headphones", 40000);
            product1.DisplayProductDetails();
            Product product2 = new Product("Laptop", 200000);
            product2.DisplayProductDetails();
            Product product3 = new Product("Screen LED", 20000);
            Product.DisplayTotalProducts();
        }


    }
}
