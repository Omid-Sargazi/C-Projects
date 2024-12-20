using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class BookBase
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public abstract decimal GetPrice();
    }
}