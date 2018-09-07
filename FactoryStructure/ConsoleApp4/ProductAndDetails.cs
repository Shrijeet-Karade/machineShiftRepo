using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhinavProject
{
    class ProductAndDetails
    {
        public IProduct GetProduct(string description)
        {
            switch (description)
            {
                case "Car": return new CarProduct();

                case "Air": return new AirProduct();

                default: return null;
            }

        }

    }
}
