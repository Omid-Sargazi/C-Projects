using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, string>
    {
        public static List<Book> _books = AddBookCommandHandler._books;
        public Task<string> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _books.FirstOrDefault(b=>b.Id==request.Id);
            if (book==null)
            {
                return Task.FromResult("Book not found!");
            }

            book.Title=request.Title;
            book.Author=request.Author;
            book.YearPublished=request.YearPublished;
            return Task.FromResult($"Book '{book.Title}' updated successfully!");
        }
    }
}