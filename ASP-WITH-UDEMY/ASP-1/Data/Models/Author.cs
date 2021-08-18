using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Data.Models
{
    public class Author
    {
        public int id { get; set; }
        public string FullName { get; set; }

        //navigation properties
        public List<Book_Author> Book_Authors{ get; set; }
    }
}
