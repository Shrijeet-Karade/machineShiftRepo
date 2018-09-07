using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cartObj = new Cart();
            cartObj.itemId = 1;
            cartObj.Item = new List<ItemDetails>();
            Inventory inventoryObj = new Inventory();
            FunctionsInsideCart cartOperationObject = new FunctionsInsideCart();
            List<ItemDetails> availableItems = inventoryObj.GetAllItems();

            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove An Item");
            Console.WriteLine("5. Total Amount Of Items in Cart");
            Console.WriteLine("\n\nEnter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter Id to Add: ");
                    int itemId = Convert.ToInt32(Console.ReadLine());
                    ItemDetails item = new ItemDetails(availableItems.Find(x => x.ItemId == itemId));
                    Console.WriteLine("Enter Number Of Item selected to be Added: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    FunctionsInsideCart.AddItem(cart, item, count);
                case 2:
                    Console.WriteLine("enter id to remove");
                    int itemId = Convert.ToInt32(Console.ReadKey());
                    FunctionsInsideCart.RemoveItem(cartObj, itemId);
                case 3:
                    Console.WriteLine("Total price of cart items is");
                    FunctionsInsideCart.GetTotalAmount(cart);
                default: break;
                    

            }
        }
    }
}
