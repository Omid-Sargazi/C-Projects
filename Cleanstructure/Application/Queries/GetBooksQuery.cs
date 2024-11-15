using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Cleanstructure.Application.Queries
{
    public class GetBooksQuery:IRequest<List<BookDTO>>{}
    {
        
    }

    public GetBooksQueryHandler:IRequestHandler<GetBooksQuery,List<BookDTO>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBooksQueryHandler(IBookRepository ookRepository)
        {
            _bookRepository = _bookRepository;
        }

        public async Task<List<Book>> Handle(GetBooksQuery request,CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return books.Select(b=>new BookDTO{Title = b.Title, ISBN = b.ISBN }).ToList();
        }
    }
}