using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FlashDealz
{
    internal class FlashDealzMain
    {
        static void Main(string[] args)
        {
            RunFlashDealzDemo();
        }

        static void RunFlashDealzDemo()
        {
            Product[] products =
            {
            new Product("Mobile", 30),
            new Product("Laptop", 50),
            new Product("Headphones", 20),
            new Product("Smart Watch", 70),
            new Product("Camera", 40),
            new Product("Shoes", 60)
        };

            ISorter quickSort = new DealzImpl();
            FlashDealz flashDealz = new FlashDealz(products, quickSort);

            flashDealz.SortProductsByDiscount();
            flashDealz.DisplayProducts();
        }
    }
}
