using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL.Entity
{
    [Table("T_Writer")]
    public class Writer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }=string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;
        public string WriterPicture { get; set; } = string.Empty;
    }
}

