using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ItemFactory
    {
        private IItemFactory foodFactory;
        private IItemFactory stationaryFactory;
        public ItemFactory()
        {
            this.foodFactory = new FoodFactory();
            this.stationaryFactory = new StationaryFactory();
        }
        public Item GetItemInstance(string itemId, string desc, double price, int quantity, ItemType itemType)
        {
            if (ItemType.FOOD == itemType)
            {
                return this.foodFactory.GetItemInstance(itemId, desc, price, quantity, itemType);
            }
            else if (ItemType.STATIONARY == itemType)
            {
                return this.stationaryFactory.GetItemInstance(itemId, desc, price, quantity, itemType);
            }

            return null;
        }
    }
}
