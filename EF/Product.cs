using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.EF
{
    [Table("products")]
    public  class Product
    {
        [Key]
        [Column("prodid")]
        public int Id { get; set; }

        [Column("prodname")]
        public string Name { get; set; }

        public int Qoh { get; set; }
        public decimal Price { get; set; }

        public string CatCode { get; set; }
        public string Remarks { get; set; }

        public virtual Category  Category { get; set; }


    }
}
