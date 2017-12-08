using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class ListProducts
    {
        static void Main(string[] args)
        {
            InventoryContext ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            var prods = from prod in ctx.Products
                        where prod.Price > 1000
                        orderby prod.Price
                        select prod;  // new { Name = prod.Name, Price = prod.Price * (decimal) 1.12 };

            foreach(var prod in prods)
            {
                Console.WriteLine("{0} - {1}", prod.Name, prod.Price, prod.Category);
            }
        }
    }
}
