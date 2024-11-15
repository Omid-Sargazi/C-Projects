using MediatR;
using System.Collections.Generic;
using LibrarySystem.Application.DTOs;

namespace Cleanstructure.Application.Queries
{
    public class GetBooksQuery:IRequest<List<BookDTO>>
    {
        
    }
}