using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, string>
    {
            public static List<Book> _books { get; } = new();

        public Task<string> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            
            var newBook = new Book
            {
                Id=_books.Count+1,
                Title=request.Title,
                Author=request.Author,
                YearPublished=request.YearPublished,
            };
            _books.Add(newBook);

            return Task.FromResult($"Book '{newBook.Title}' added successfully!");
    
        }
    }
}