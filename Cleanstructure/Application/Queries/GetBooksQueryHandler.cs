using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleanstructure.Application.Queries
{
    public class GetBooksQueryHandler:IRequestHandler<GetBooksQuery,List<BookDTO>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBooksQueryHandler(IBookRepository bookRepository)
        {
             _bookRepository = bookRepository;
        }

        public async Task<List<BookDTO>> Handle(GetBooksQuery query,CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return books.Select(b => new BookDTO { Title = b.Title, ISBN = b.ISBN }).ToList();
        }
    }
}