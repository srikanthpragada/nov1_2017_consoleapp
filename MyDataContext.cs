using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MyDataContext : DataContext 
    {
        public MyDataContext() : 
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public Table<Category> Categories
        {
            get
            {
                return GetTable<Category>();
            }
        }
    }
}
