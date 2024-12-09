using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Entities;
using FluentValidation;

namespace Core.Validators
{
    public class BookValidator:AbstractValidator<BookDTO>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(book => book.Author).NotEmpty().WithMessage("Author is required.");
            RuleFor(book => book.ISBN).NotEmpty().Length(13).WithMessage("ISBN must be 13 characters.");
        }
    }
}