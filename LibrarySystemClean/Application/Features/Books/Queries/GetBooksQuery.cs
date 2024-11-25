using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Application.DTOs;

namespace Application.Features.Books.Queries
{
    public class GetBooksQuery:IRequest<IEnumerable<BookDTO>>
    {
        
    }
}