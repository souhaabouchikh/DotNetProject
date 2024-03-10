using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_FavoriteBook")]
    public class FavoriteBook
    {
        [Key]
        public int FavoriteId { get; set; }
        public int BookId { get; set; }
    }
}
