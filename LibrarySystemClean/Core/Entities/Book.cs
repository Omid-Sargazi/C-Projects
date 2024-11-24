using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsAvailable { get; set; }


        public void MarkAsBorrowed()
        {
            if(!IsAvailable)
            {
                throw new InvalidOperationException("Book is already borrowed.");
                IsAvailable=false;
            }
        }

        public void MarkAsReturned()
        {
            if(IsAvailable)
            {
                throw new InvalidOperationException("Book is already available.");
                IsAvailable=true;
            }
        }
    }
}