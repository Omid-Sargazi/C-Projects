using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrarySystem.DTOs
{
    public class BookCreateDto
    {
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}