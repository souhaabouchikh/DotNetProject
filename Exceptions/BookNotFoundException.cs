using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class BookNotFoundException:Exception
    {
        public BookNotFoundException(int BookId) : base($"Book with ID {BookId} not found.")
        {
        }
    }
}
