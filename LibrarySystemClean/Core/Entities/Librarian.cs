using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Librarian:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}