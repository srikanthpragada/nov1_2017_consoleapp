using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class AddProduct
    {
        static void Main(string[] args)
        {
            InventoryContext ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            Product prod = new Product { Name = "Google Pixel 2", Price = 50000, Qoh = 2, Category = "ph", Remarks = "Google Lens" };

            ctx.Products.Add(prod);
            ctx.SaveChanges();

        }
    }
}
