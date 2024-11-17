using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Application.Commands
{
    public class CreateBookCommandHandler:IRequestHandler<CreateBookCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title,request.Author,request.ISBN);
            var bookId = await _unitOfWork.bookRepository.AddBookAsync(book);
            await _unitOfWork.CompleteAsync().
            return bookId;
        }
    }
}