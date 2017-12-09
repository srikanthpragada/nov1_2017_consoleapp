using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class TransDemo
    {
        static void Main(string[] args)
        {
            InventoryContext ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            var prod = ctx.Products.Find(2104);  // Select
            prod.CatCode = "phone";

            prod = ctx.Products.Find(2106);  // Select
            prod.Price = 50000;
            prod.Remarks = "2 years warrenty";

            ctx.SaveChanges();
        }
    }
}

