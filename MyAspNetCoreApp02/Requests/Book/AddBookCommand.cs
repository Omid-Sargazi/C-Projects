
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp02.Requests.Book
{
    public class AddBookCommand:IRequest<string>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
    }
}