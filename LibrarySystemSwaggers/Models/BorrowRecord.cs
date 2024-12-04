using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystemSwaggers.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }

        public Member Member { get; set; }
        public Book Book{ get; set; }
    }
}