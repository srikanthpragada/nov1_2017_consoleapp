using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            MyDataContext dc = new MyDataContext();
            dc.Log = Console.Out;


            foreach (var cat in dc.Categories.OrderBy(c => c.Description))
                Console.WriteLine(cat.Description);
        }
    }
}
