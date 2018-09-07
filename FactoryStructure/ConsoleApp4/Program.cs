using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhinavProject
{
   public class Program
    {
       public static void Main(string[] args)
        {
            ProductAndDetails obj = new ProductAndDetails();
            Console.WriteLine("Enter the Type of product you want");
            Console.WriteLine("Enter 'Car' for CarProduct \n Enter 'Air' for Air Product");


            string desc = Console.ReadLine();
            IProduct prod = obj.GetProduct(desc);
            
            Console.WriteLine("enter --book-- to Book That Product \n Enter --save-- To Save that product");
            string choice= Console.ReadLine();
            if (choice == "book")
            {
                prod.GetTypeofProduct();
                prod.Book();
            }
            else if (choice == "save")
            {
                prod.GetTypeofProduct();
                prod.Save();
            }
            else
            {
                Console.WriteLine("invalid function chosen, exiting App");
            }
            Console.ReadKey();
        }

      
    }
    
}
