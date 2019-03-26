using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class FoodFactory : IItemFactory
    {
       public Item GetItemInstance(string itemId, string desc, double price, int quantity, ItemType itemType)
       {
            if (ItemType.FOOD == itemType)
            {
                return new Chocolate(itemId, desc, price, quantity, itemType);
            }

            return null;
        }
    }
}
