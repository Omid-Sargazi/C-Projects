using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
namespace Cleanstructure.Application
{
    public class CreateBookCommand:IRequest<int>
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
    }

    public class CreateBookCommandHandler:IRequestHandler<CreateBookCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async Task<int> Handle(CreateBookCommand request,CancellationToken cancellationToken)
    {
        var book = new Book {Title=request.Title, ISBN=request.};
        _unitOfWork.BookRepository
        await _unitOfWork.CommitAsync();
        return book.Id;

    }
    }
}