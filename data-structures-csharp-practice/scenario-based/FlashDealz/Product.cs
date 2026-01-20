using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FlashDealz
{
    internal class Product
    {
        public string Name {  get; set; }
        public int Discount {  get; set; }
        public Product(string name, int discount)
        {
            Name = name;
            Discount = discount;
        }
    }
}
