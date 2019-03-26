using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = Inventory.Instance;
            ItemFactory itemFactory = new ItemFactory();
            Item createdItem = itemFactory.GetItemInstance("1", "books", 30, 3, ItemType.STATIONARY);
            inv.AddToInventory(createdItem);
            createdItem = itemFactory.GetItemInstance("2", "chocolates", 1, 3, ItemType.STATIONARY);
            inv.AddToInventory(createdItem);

            Receipt receipt = new Receipt();
            Item item = inv.GetItemFromInventory("1", 3);
            if (item != null)
            {
                receipt.AddItemsToReceipt(item, 1);
            }
            else
            {
                Console.WriteLine(" Not in inventory");
            }

            item = inv.GetItemFromInventory("2", 1);
            if (item != null)
            {
                receipt.AddItemsToReceipt(item, 1);
            }
            else
            {
                Console.WriteLine(" Not in inventory");
            }
            
            item = inv.GetItemFromInventory("3", 2);
            if (item != null)
            {
                receipt.AddItemsToReceipt(item, 2);
            }
            else
            {
                Console.WriteLine(" Not in inventory");
            }
            receipt.PrintReceipt();
            
            Console.ReadLine();
        }
    }
}
