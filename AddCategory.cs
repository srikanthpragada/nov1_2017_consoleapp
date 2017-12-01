using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AddCategory
    {
        static void Main(string[] args)
        {
            MyDataContext dc = new MyDataContext();
            dc.Log = Console.Out; 

            Category cat = new Category { Code = "ph", Description = "Smart Phones" };

            dc.Categories.InsertOnSubmit(cat);
            Console.ReadLine();
            dc.SubmitChanges();

        }
    }
}
