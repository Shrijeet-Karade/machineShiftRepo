using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class Cart
    {
        public int ItemID{get ;set;}
        public List<ItemDetails> CartItem { get; set; }
    }
}
