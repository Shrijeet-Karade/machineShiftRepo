using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhinavProject
{
    class AirProduct : IProduct
    {
        public string GetTypeofProduct()
        {
            return "AirProduct";
        }
        public void Book()
        {
            Console.WriteLine("Booking the CarProduct");
        }

    
        public void Save()
        {
            Console.WriteLine("Saving the car Product");
        }
    }
}
