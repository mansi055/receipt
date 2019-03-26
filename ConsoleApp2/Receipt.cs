using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Receipt
    {
        private List<Item> items;

        private double totalPrice;

        private double totalTax;

        private Dictionary<string, int> itemQuantity;

        public Receipt()
        {
            this.items = new List<Item>();
            this.totalPrice = 0;
            this.totalTax = 0;
        }
        public void AddItemsToReceipt(Item item, int quantity)
        {
            item.SetItemQuantity(quantity);
            items.Add(item);           
        }

        private double GetTotalPrice()
        {
            foreach(Item item in items)
            {
                this.totalPrice += item.GetItemQuantity() * item.GetTotalPrice();
            }

            return this.totalPrice;
        }

        private double GetTotalTax()
        {
            foreach (Item item in items)
            {
                this.totalTax += item.GetItemTax();
            }

            return this.totalTax;
        }

        public void PrintReceipt()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.GetItemQuantity() + " " + item.GetItemName() + " " + item.GetPrice());
            }
            Console.WriteLine("Sales Tax:" + GetTotalTax());
            Console.WriteLine("Total:" + GetTotalPrice());
        }
    }
}
