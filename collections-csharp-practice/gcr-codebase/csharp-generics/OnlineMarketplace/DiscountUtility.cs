using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.DynamicOnlineMarketplace
{
    public static class DiscountUtility
    {
        public static void ApplyDiscount<T>(T product, double percentage)
            where T : Product
        {
            double discountedPrice =
                product.Price - (product.Price * percentage / 100);

            product.UpdatePrice(discountedPrice);
        }
    }
}
