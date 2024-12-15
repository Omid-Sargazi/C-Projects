using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class LibraryMember
    {
       public int Id {get;set;}
        public string FullName { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new(); 
    }
}