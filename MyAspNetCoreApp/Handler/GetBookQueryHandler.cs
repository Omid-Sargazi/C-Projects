using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, Book>
    {
        private static List<Book> _books = AddBookCommandHandler._books;
        public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var book = _books.FirstOrDefault(b=>b.Id==request.Id);
            return Task.FromResult(book);
        }
    }
}