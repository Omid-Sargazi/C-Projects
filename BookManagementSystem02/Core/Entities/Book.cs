using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            if(string.IsNullOrEmpty(title)) throw new ArgumentNullException("Title is required");
            if(string.IsNullOrEmpty(author)) throw new ArgumentNullException("author is required");
            if(string.IsNullOrWhiteSpace(isbn)) throw new ArgumentNullException("isbn is required");

            Title=title;
            Author=author;
            ISbn=isbn;
        }

        public void UpdateDetails()
    }
}