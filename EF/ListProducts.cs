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

            //var prods = from prod in ctx.Products
            //            where prod.Price > 1000
            //            orderby prod.Price
            //            select prod;  // new { Name = prod.Name, Price = prod.Price * (decimal) 1.12 };

            //var allprods = from prod in ctx.Products
            //               select new { Name = prod.Name, CatDesc = prod.Category.CatDesc };

            //foreach(var prod in allprods)
            //{
            //    Console.WriteLine("{0} - {1}", prod.Name, prod.CatDesc );
            //}

            // Console.ReadLine();

            foreach (var prod in ctx.Products.Include("Category"))
            {
                // Console.WriteLine(prod.GetType().FullName);
                Console.WriteLine("{0} - {1}", prod.Name, prod.Category.CatDesc);
            }
        }
    }
}
