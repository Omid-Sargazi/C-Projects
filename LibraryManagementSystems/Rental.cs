using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystems
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; } // Navigation property
        public int MemberId { get; set; }
        public Member Member { get; set; } // Navigation property
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}