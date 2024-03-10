using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CreateListsVM
    {
        public List<WriterViewModel> writers { get; set; }
        public List<CategoryViewModel> Cats { get; set; }
    }
}
