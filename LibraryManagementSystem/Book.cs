using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book:BookBase
    {
        private decimal _price;
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}