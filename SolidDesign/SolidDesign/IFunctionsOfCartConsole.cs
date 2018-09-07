using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    interface IFunctionsOfCartConsole
    {
        List<ItemDetails> GetCartItems(Cart cart);
        void AddItem(Cart cart, ItemDetails item);
        void RemoveItem(Cart cart, int itemId);

        int GetTotalAmount(Cart cart);

       
    }
}
