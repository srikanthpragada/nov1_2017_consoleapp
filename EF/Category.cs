using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{

    public class Category
    {
        [Key]
        public string CatCode { get; set; }
        public string CatDesc { get; set; }

    }
}
