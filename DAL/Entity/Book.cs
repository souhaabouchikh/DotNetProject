using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Book")]
    public class Book
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Year { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int IdCategory { get; set; }
        public string BookImage { get; set; } = string.Empty;

        [Column("AddingTime", TypeName = "DateTime2")]
        public DateTime AddingTime { get; set; }
        public bool Disponibility { get; set; }
        public bool isDiscounted { get; set; }
        public decimal DiscountPrice { get; set; }

        public int WriterId { get; set; }
       
    }
}
