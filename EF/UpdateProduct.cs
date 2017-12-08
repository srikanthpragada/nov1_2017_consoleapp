using System;
using System.Collections.Generic;
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
                prod.Price = 55000;
                prod.Remarks = "New Camera with more power";
                ctx.SaveChanges();
            }
        }

    }
}
