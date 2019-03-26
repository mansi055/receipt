using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public sealed class Inventory
    {
        private static int totalItems;

        private static double totalPrice;

        private static List<Item> items;

        private static double taxRate;

        private static readonly Inventory instance = new Inventory();

        static Inventory()
        {
            taxRate = 0.20;
            items = new List<Item>();
        }

        private Inventory()
        {
        }

        public static Inventory Instance
        {
            get
            {
                return instance;
            }
        }
        
        public void AddToInventory(Item item)
        {
            if(item.GetItemType() != ItemType.MEDICAL)
            {
                CalculateItemTax(item);
            }
            items.Add(item);
        }
        
        public void CalculateItemTax(Item item)
        {
            double tax = item.GetPrice() * taxRate;
            item.SetItemTax(tax);
        }

        public List<Item> GetInventoryItems()
        {
            return items;
        }

        public void PrintInventoryItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.GetItemQuantity() + " " + item.GetItemName() + " " + item.GetPrice() + " " + item.GetItemTax());
            }
        }

        public int GetItemQuantityFromInventory(string itemId)
        {
            foreach (Item item in items)
            {
                if (string.Equals(item.GetItemID(), itemId))
                {
                    return item.GetItemQuantity();
                }
            }
            return -1;
        }

        public bool SetItemQuantityFromInventory(string itemId, int quantity)
        {
            foreach (Item item in items)
            {
                if (string.Equals(item.GetItemID(), itemId))
                {
                    int q = item.GetItemQuantity();
                    item.SetItemQuantity(quantity);
                    return true;
                }
            }
            return false;
        }

        public Item GetItemFromInventory(string itemId, int quantity)
        {
            int currentQuantity = this.GetItemQuantityFromInventory(itemId);
            foreach (Item item in items)
            {
                if (string.Equals(item.GetItemID(), itemId))
                {
                    SetItemQuantityFromInventory(itemId, currentQuantity - quantity);
                    return item;
                }
            }
            return null;
        }
    }
}
