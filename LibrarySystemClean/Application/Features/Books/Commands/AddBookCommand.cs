using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Core.Entities;
using Application.DTOs;

namespace Application.Features.Books.Commands
{
    public class AddBookCommand:IRequest<int>
    {
        public BookDTO Book { get; set; }
    }
}