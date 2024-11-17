using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Application.Queries
{
    public class GetAllBooksQueryHandler:IRequestHandler<GetAllBooksQuery,List<BookDTO>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper mapper;


        public GetAllBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDTO>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return _mapper.Map<List<BookDTO>>(books);
        }
    }
}