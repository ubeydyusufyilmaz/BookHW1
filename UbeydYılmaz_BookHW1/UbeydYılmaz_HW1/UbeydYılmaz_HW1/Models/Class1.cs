using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeydYılmaz_HW1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public string Author { get; set; }

        public Publisher Publisher { get; set; }
    }
    public class Publisher
    {
        public string Id { get; set; }

        public string PublisherTitle { get; set; }
        public ICollection<Book> Books { get; set;}
    }
}
