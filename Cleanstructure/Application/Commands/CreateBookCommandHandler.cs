using System.Threading;
using System.Threading.Tasks;
using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Interfaces;
using MediatR;

namespace Cleanstructure.Application.Commands
{
    public class CreateBookCommandHandler:IRequestHandler<CreateBookCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateBookCommand request,CancellationToken cancellationToken)
        {
            var book = new Book{
                Title = request.Title,
                ISBN = request.ISBN,
            }

            _unitOfWork.BookRepository.Add(book);

            await _unitOfWork.CommitAsync();

            return book.Id;
        }
    }
    
}