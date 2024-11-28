using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, string>
    {
        private static List<Book> _books = AddBookCommandHandler._books;
        public Task<string> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = _books.FirstOrDefault(b=>b.Id==request.Id);
            if(book==null){
                return Task.FromResult("Book not found!");
            }
             _books.Remove(book);
            return Task.FromResult($"Book '{book.Title}' deleted successfully!");
    
        }
    }
}