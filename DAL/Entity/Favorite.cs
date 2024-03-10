using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("Favorite")]
    public class Favorite
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
    }
}
