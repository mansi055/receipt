using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class LiquorFactory : IItemFactory
    {
        public Item GetItemInstance(string itemId, string desc, double price, int quantity, ItemType itemType)
        {
            throw new NotImplementedException();
        }
    }
}
