using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class FunctionsInsideCart: IFunctionsOfCartConsole
    {
    
        public void AddItem(Cart cart, Item item, int CountOfItemsToAdd)
        {
            for (int index = 0; index < CountOfItemsToAdd; index++)
            {
                cart.Items.Add(item);
            }
        }

        public void AddItem(Cart cart, ItemDetails item)
        {
            throw new NotImplementedException();
        }

        public List<ItemDetails> GetCartItems(Cart cart)
        {
            return cart.Items;
        }

        public float GetTotalAmount(Cart cart)
        {
            float totalAmount = 0;
            for (int index = 0; index < cart.Items.Count; index++)
            {
                totalAmount += cart.Items[index].ItemPrice;
            }
            return totalAmount;
        }

        public void RemoveItem(Cart cart, int itemId)
        {
            ItemDetails itemToRemove = cart.Items.Find(item => item.ItemId == itemId);
            cart.Items.Remove(itemToRemove);
        }

        List<ItemDetails> IFunctionsOfCartConsole.GetCartItems(Cart cart)
        {
            throw new NotImplementedException();
        }

        int IFunctionsOfCartConsole.GetTotalAmount(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
