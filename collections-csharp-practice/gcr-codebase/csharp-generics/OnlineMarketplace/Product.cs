using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.DynamicOnlineMarketplace
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public double Price { get; private set; }

        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // (Encapsulation)
        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

        public abstract void Display();
    }
}
