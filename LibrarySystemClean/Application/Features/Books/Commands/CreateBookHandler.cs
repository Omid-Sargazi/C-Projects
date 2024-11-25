using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Core.Interfaces;
using AutoMapper;
using Core.Entities;

namespace Application.Features.Books.Commands
{
    public class CreateBookHandler:IRequestHandler<CreateBookCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBookHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
           _unitOfWork = unitOfWork;
           _mapper = mapper; 
        }

        public async Task<int> Handle(CreateBookCommand request,CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request.Book);
            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveChangesAsync();
            return book.Id;
        }
    }
}