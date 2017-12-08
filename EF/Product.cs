﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.EF
{
    [Table("products")]
    class Product
    {
        [Key]
        [Column("prodid")]
        public int Id { get; set; }

        [Column("prodname")]
        public string Name { get; set; }

        public int Qoh { get; set; }
        public decimal Price { get; set; }

        [Column("catcode")]
        public string Category { get; set; }
        public string Remarks { get; set; }
    }
}
