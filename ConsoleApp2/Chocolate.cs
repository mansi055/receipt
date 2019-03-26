using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Chocolate : Item
    {
        public Chocolate(string itemId, string name, double price, int quantity, ItemType itemType) : base(itemId, name, price, quantity, itemType)
        {

        }
    }
}
