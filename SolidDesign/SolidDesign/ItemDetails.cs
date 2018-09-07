using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class ItemDetails
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public ItemDetails () { }
        public ItemDetails(ItemDetails item)
        {
            this.ItemId = item.ItemId;
            this.ItemName = item.ItemName;
            this.ItemPrice = item.ItemPrice;
        }
    }
}
