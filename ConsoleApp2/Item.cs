using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Item
    {
        private string itemId;

        private string description;

        private double price;

        private ItemType itemType;

        private double tax;

        private int quantity;

        public Item()
        {

        }

        public Item(string itemId, string name, double price, int quantity, ItemType itemType)
        {
            this.itemId = itemId;
            this.description = name;
            this.price = price;
            this.quantity = quantity;
            this.itemType = itemType;
        }

        public string GetItemID()
        {
            return this.itemId;
        }
        public string GetItemName()
        {
            return this.description;
        }

        public int GetItemQuantity()
        {
            return this.quantity;
        }

        public void SetItemQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public ItemType GetItemType()
        {
            return this.itemType;
        }

        public void SetItemTax(double tax)
        {
            this.tax = tax;
        }

        public double GetItemTax()
        {
            return this.tax;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public double GetTotalPrice()
        {
            return this.price + this.tax;
        }
    }
}
