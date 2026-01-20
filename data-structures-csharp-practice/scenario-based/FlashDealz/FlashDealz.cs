using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FlashDealz
{
    internal class FlashDealz
    {
        private Product[] products;
        private ISorter sortStrategy;

        public FlashDealz(Product[] products, ISorter sortStrategy)
        {
            this.products = products;
            this.sortStrategy = sortStrategy;
        }

        public void SortProductsByDiscount()
        {
            sortStrategy.Sort(products);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("FlashDealz – Products Sorted by Discount:");
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Name} : {p.Discount}%");
            }
        }
    }
}
