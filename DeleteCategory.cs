using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DeleteCategory
    {
        static void Main(string[] args)
        {
            MyDataContext dc = new MyDataContext();
            dc.Log = Console.Out;

            // var cat = dc.Categories.Where(c => c.Code == "ph").FirstOrDefault();


            var cat = (from c in dc.Categories
                      where c.Code == "ph"
                      select c).FirstOrDefault();

            if (cat == null)
            {
                Console.WriteLine("Sorry! Category Not Found!");
                return;
            }

            dc.Categories.DeleteOnSubmit(cat);
            dc.SubmitChanges();

        }
    }
}
