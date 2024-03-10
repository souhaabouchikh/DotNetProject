using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Year { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int Writer { get; set; }

        public int IdCategory { get; set; }
        public IFormFile Image { get; set; }
        public string BookImage{ get; set; }
        public DateTime AddingTime { get; set; }=DateTime.Now;
        public bool Disponibility { get; set; }
        public bool isDiscounted { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}
