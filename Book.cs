using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Book
    {
         public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public char Gender { get; set; }
        public string IsAvailable { get; set; }
    }
}
