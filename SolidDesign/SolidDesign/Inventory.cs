using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class Inventory
    {
        private List<ItemDetails> _itemsInventory = new List<ItemDetails>()
        {
            new ItemDetails() { ItemId=1, ItemName="pubG", ItemPrice=10000 },
            new ItemDetails() { ItemId=2, ItemName="COD", ItemPrice=5000},

        };

        public List<ItemDetails> GetAllItems()
        {
            return this._itemsInventory;
        }
    }
}
