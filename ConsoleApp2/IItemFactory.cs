using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface IItemFactory
    {
        Item GetItemInstance(string itemId, string desc, double price, int quantity, ItemType itemType);
    }
}
