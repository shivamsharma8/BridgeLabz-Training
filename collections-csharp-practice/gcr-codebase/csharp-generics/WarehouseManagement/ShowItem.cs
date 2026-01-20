using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.generics.warehousemanagement
{
    
        public class ShowItem
        {
            public static void DisplayWarehouseItems(IReadOnlyList<WareHouseSystem> items)
            {
                foreach (var item in items)
                {
                    item.Show();
                }
            }
        }
    
}
