using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Author:BaseEntity
    {
        public List<Book> Books { get; set; } = new List<Book>();
    }
}