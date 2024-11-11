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

    public class Member:BaseEntity
    {
        public string Email { get; set; }
        public List<Rental> Rentals { get; set;} = new List<Rental>();
    }
}