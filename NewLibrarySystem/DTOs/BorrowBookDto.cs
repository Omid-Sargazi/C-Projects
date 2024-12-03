using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrarySystem.DTOs
{
    public class BorrowBookDto
    {
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime DueDate{ get; set; }
    }
}