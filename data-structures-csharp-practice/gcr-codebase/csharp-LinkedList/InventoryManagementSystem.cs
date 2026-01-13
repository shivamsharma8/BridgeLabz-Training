using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    public class ItemNode
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public ItemNode Next;

        public ItemNode(int itemId, string itemName, int quantity, double price)
        {
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    // Singly Linked List
    class InventoryLinkedList
    {
        private ItemNode head;

        // Add at beginning
        public void AddAtBeginning(int id, string name, int qty, double price)
        {
            ItemNode newNode = new ItemNode(id, name, qty, price);
            newNode.Next = head;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(int id, string name, int qty, double price)
        {
            ItemNode newNode = new ItemNode(id, name, qty, price);

            if (head == null)
            {
                head = newNode;
                return;
            }

            ItemNode temporaryTraversal = head;
            while (temporaryTraversal.Next != null)
                temporaryTraversal = temporaryTraversal.Next;

            temporaryTraversal.Next = newNode;
        }

        // Add at specific position
        public void AddAtPosition(int position, int id, string name, int qty, double price)
        {
            if (position <= 1 || head == null)
            {
                AddAtBeginning(id, name, qty, price);
                return;
            }

            ItemNode temporaryTraversal = head;
            for (int i = 1; i < position - 1 && temporaryTraversal.Next != null; i++)
                temporaryTraversal = temporaryTraversal.Next;

            ItemNode newNode = new ItemNode(id, name, qty, price);
            newNode.Next = temporaryTraversal.Next;
            temporaryTraversal.Next = newNode;
        }

        // Remove by Item ID
        public void RemoveByItemId(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            if (head.ItemId == id)
            {
                head = head.Next;
                Console.WriteLine("Item removed successfully");
                return;
            }

            ItemNode temporaryTraversal = head;
            while (temporaryTraversal.Next != null && temporaryTraversal.Next.ItemId != id)
                temporaryTraversal = temporaryTraversal.Next;

            if (temporaryTraversal.Next == null)
                Console.WriteLine("Item not found");
            else
            {
                temporaryTraversal.Next = temporaryTraversal.Next.Next;
                Console.WriteLine("Item removed successfully");
            }
        }

        // Update quantity by Item ID
        public void UpdateQuantity(int id, int newQty)
        {
            ItemNode temporaryTraversal = head;
            while (temporaryTraversal != null)
            {
                if (temporaryTraversal.ItemId == id)
                {
                    temporaryTraversal.Quantity = newQty;
                    Console.WriteLine("Quantity updated successfully");
                    return;
                }
                temporaryTraversal = temporaryTraversal.Next;
            }
            Console.WriteLine("Item not found");
        }

        // Search by Item ID
        public void SearchByItemId(int id)
        {
            ItemNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    DisplayItem(temp);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        // Search by Item Name
        public void SearchByItemName(string name)
        {
            ItemNode temporaryTraversal = head;
            bool found = false;

            while (temporaryTraversal != null)
            {
                if (temporaryTraversal.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayItem(temporaryTraversal);
                    found = true;
                }
                temporaryTraversal = temporaryTraversal.Next;
            }

            if (!found)
                Console.WriteLine("Item not found");
        }

        // Calculate total inventory value
        public void CalculateTotalValue()
        {
            double total = 0;
            ItemNode temp = head;

            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.Next;
            }

            Console.WriteLine("Total Inventory Value: ₹" + total);
        }

        // Sort inventory
        public void SortInventory(string sortBy, bool ascending)
        {
            if (head == null)
                return;

            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    bool condition = false;

                    if (sortBy == "name")
                        condition = ascending ?
                            string.Compare(i.ItemName, j.ItemName) > 0 :
                            string.Compare(i.ItemName, j.ItemName) < 0;

                    else if (sortBy == "price")
                        condition = ascending ?
                            i.Price > j.Price :
                            i.Price < j.Price;

                    if (condition)
                        SwapData(i, j);
                }
            }

            Console.WriteLine("Inventory sorted successfully");
        }

        // Swap node data
        private void SwapData(ItemNode a, ItemNode b)
        {
            (a.ItemId, b.ItemId) = (b.ItemId, a.ItemId);
            (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
            (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
            (a.Price, b.Price) = (b.Price, a.Price);
        }

        // Display all items
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            ItemNode temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.Next;
            }
        }

        private void DisplayItem(ItemNode item)
        {
            Console.WriteLine(
                $"{item.ItemId} | {item.ItemName} | Qty: {item.Quantity} | Price: ₹{item.Price}");
        }
    }

    class InventoryManagementSystem
    {
        static void Main()
        {
            InventoryLinkedList inventory = new InventoryLinkedList();

            inventory.AddAtEnd(101, "Laptop", 5, 50000);
            inventory.AddAtBeginning(102, "Mouse", 20, 500);
            inventory.AddAtPosition(2, 103, "Keyboard", 10, 1500);

            Console.WriteLine("All Items:");
            inventory.DisplayAll();

            Console.WriteLine("Search Item ID 103:");
            inventory.SearchByItemId(103);

            Console.WriteLine("Update Quantity:");
            inventory.UpdateQuantity(102, 25);

            Console.WriteLine("Total Inventory Value:");
            inventory.CalculateTotalValue();

            Console.WriteLine("Sort by Price (Descending):");
            inventory.SortInventory("price", false);
            inventory.DisplayAll();

            Console.WriteLine("Remove Item ID 101:");
            inventory.RemoveByItemId(101);

            Console.WriteLine("Final Inventory:");
            inventory.DisplayAll();
        }
    }
}
