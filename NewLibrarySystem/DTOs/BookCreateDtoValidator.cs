using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace NewLibrarySystem.DTOs
{
    public class BookCreateDtoValidator:AbstractValidator<BookCreateDto>
    {
        public BookCreateDtoValidator()
        {
            RuleFor(b=>b.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(b=>b.PublishedDate).LessThanOrEqualTo(DateTime.Now).WithMessage("Published date cannot be in the future.");
        }
    }
}