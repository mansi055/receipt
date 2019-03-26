using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class StationaryFactory : IItemFactory
    {
        public Item GetItemInstance(string itemId, string desc, double price, int quantity, ItemType itemType)
        {
            if (ItemType.STATIONARY == itemType)
            {
                return new Chocolate(itemId, desc, price, quantity, itemType);
            }

            return null;
        }
    }
}
