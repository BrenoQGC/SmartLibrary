using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Entities
{
    internal class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
            IsRemoved = false;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int? PublicationYear { get; set; }
        public bool IsRemoved { get; set; }
    }
}
