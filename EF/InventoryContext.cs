﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class InventoryContext : DbContext
    {
        public InventoryContext() :
             base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
            // disable migration 
            Database.SetInitializer<InventoryContext>(null);
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
