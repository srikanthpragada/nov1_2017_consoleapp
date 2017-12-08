using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class DeleteProduct
    {
        static void Main(string[] args)
        {
            InventoryContext ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            var prod = ctx.Products.Find(4104);

            if (prod == null)
                Console.WriteLine("Product Not Found!");
            else
            {
                ctx.Products.Remove(prod);
                ctx.SaveChanges();
            }
        }
    }
}
