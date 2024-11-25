using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using MediatR;
using Application.DTOs;
using AutoMapper;

namespace Application.Features.Books.Queries
{
    public class GetBooksHandler:IRequestHandler<GetBooksQuery,IEnumerable<BookDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public GetBooksHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

     public async Task<IEnumerable<BookDTO>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _unitOfWork.Books.GetAllAsync();
        return _mapper.Map<IEnumerable<BookDTO>>(books);
    }
    }
}