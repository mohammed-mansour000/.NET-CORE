using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Data.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }

        //navigation properties
        public List<Book> Books { get; set; }
    }
}
