using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class UpdateProduct
    {
        static void Main(string[] args)
        {
            InventoryContext ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            var prod = ctx.Products.Find(2106);

            if (prod == null)
                Console.WriteLine("Product Not Found!");
            else
            {
                Console.WriteLine(ctx.Entry(prod).State);
                prod.Price = 52000;
                prod.Remarks = "New Camera with more power";
                Console.WriteLine(ctx.Entry(prod).State);
                ctx.SaveChanges();
            }

            // Detach an object from Context 
            var adapter = (IObjectContextAdapter) ctx;
            var objctx = adapter.ObjectContext;
            objctx.Detach(prod);

            Console.WriteLine(ctx.Entry(prod).State);

            prod.Price = 60000;
            ctx.SaveChanges();

           
        }

    }
}
