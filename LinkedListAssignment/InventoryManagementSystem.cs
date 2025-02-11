using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{

    // Node representing an inventory item
    class InventoryNode
    {
        public int ItemID;
        public string ItemName;
        public int Quantity;
        public double Price;
        public InventoryNode Next;

        public InventoryNode(int id, string name, int quantity, double price)
        {
            ItemID = id;
            ItemName = name;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    class InventoryManagementSystem
    {
        private InventoryNode head = null;

        // Add an item at the beginning
        public void AddAtBeginning(int id, string name, int quantity, double price)
        {
            InventoryNode newNode = new InventoryNode(id, name, quantity, price);
            newNode.Next = head;
            head = newNode;
        }

        // Add an item at the end
        public void AddAtEnd(int id, string name, int quantity, double price)
        {
            InventoryNode newNode = new InventoryNode(id, name, quantity, price);
            if (head == null)
            {
                head = newNode;
                return;
            }
            InventoryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Remove an item based on Item ID
        public void RemoveItem(int id)
        {
            if (head == null) return;
            if (head.ItemID == id)
            {
                head = head.Next;
                return;
            }
            InventoryNode temp = head, prev = null;
            while (temp != null && temp.ItemID != id)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null) return;
            prev.Next = temp.Next;
        }

        // Update the quantity of an item by Item ID
        public void UpdateQuantity(int id, int newQuantity)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemID == id)
                {
                    temp.Quantity = newQuantity;
                    return;
                }
                temp = temp.Next;
            }
        }

        // Search for an item by ID or Name
        public void SearchItem(int id)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemID == id)
                {
                    Console.WriteLine($"Found Item: ID={temp.ItemID}, Name={temp.ItemName}, Quantity={temp.Quantity}, Price={temp.Price}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found.");
        }

        public void SearchItem(string name)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found Item: ID={temp.ItemID}, Name={temp.ItemName}, Quantity={temp.Quantity}, Price={temp.Price}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found.");
        }

        // Calculate and display total inventory value
        public void CalculateTotalValue()
        {
            double totalValue = 0;
            InventoryNode temp = head;
            while (temp != null)
            {
                totalValue += temp.Price * temp.Quantity;
                temp = temp.Next;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }

        // Display all items
        public void DisplayItems()
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID={temp.ItemID}, Name={temp.ItemName}, Quantity={temp.Quantity}, Price={temp.Price}");
                temp = temp.Next;
            }
        }
    }
    
}
