using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WriterViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;
        public string WriterPicture { get; set; } = string.Empty;
    }
}
