using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Queries
{
    public class GetAllBooksQuery
    {
        public List<Book> Books { get; set; }
    }
}