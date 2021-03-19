using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item : IComparable<Item>
    {
        private int itemId;
        private String itemName;
        private int quantity;
        private float price;

        public Item(int itemId, string itemName, int quantity, float price)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
        }

        public int ItemId { get => itemId; set => itemId = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }

        public int CompareTo(Item other)
        {
            return other.quantity - quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Item)
            {
                Item i = obj as Item;
                if (i.itemId == itemId)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return itemName + " qty: " + quantity + ", " + price + " LKR.";
        }
    }
}
