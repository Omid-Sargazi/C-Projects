using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystemBackend.DTOs
{
    public class BookUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}