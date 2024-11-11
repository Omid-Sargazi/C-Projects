using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book:BookBase
    {
        private decimal _price;
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public void SetPrice(decimal price)
        {
            if(price<=0)
            {
                throw new ArgumentException("Price must be positive.");
            }
            _price = price;
        }
    }
}