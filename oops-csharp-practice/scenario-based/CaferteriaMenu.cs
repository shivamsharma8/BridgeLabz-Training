using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.scenario_based
{
    public class CaferteriaMenu
    {
        static string[] menuItems ={"Sandwich","Burger","Pizza","Pasta","Fried Rice","Noodles","Coffee","Tea","Juice","Ice Cream"};

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Campus Cafeteria ");

            // Display menu
            DisplayMenu();

            Console.Write("Enter the index number of the item you want to order: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Get selected item
            string selectedItem = GetItemByIndex(index);

            if (selectedItem != null)
            {
                Console.WriteLine("You have ordered: " + selectedItem);
            }
            else
            {
                Console.WriteLine("Invalid selection! Please choose a valid index.");
            }
        }

        // Method to display menu
        static void DisplayMenu()
        {
            Console.WriteLine("Today's Menu:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(i + " - " + menuItems[i]);
            }
        }

        // Method to get item by index
        static string GetItemByIndex(int index)
        {
            if (index >= 0 && index < menuItems.Length)
            {
                return menuItems[index];
            }
            return null;
        }
    }
}
