using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Core.Interfaces;
using Core.Entities;


namespace Application.Features.Books.Commands
{
    public class AddBookHandler:IRequestHandler<AddBookCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddBookHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddBookCommand request , CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request.Book);
            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CompleteAsync();
            return book.Id;
        }
    }
}