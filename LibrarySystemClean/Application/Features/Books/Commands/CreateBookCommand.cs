using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features.Books.Commands
{
    public class CreateBookCommand:IRequest<int>
    {
        public BookDTO Book { get; set; }
    }
}