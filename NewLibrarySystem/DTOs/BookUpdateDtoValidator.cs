using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace NewLibrarySystem.DTOs
{
    public class BookUpdateDtoValidator:AbstractValidator<BookUpdateDto>
    {
        public BookUpdateDtoValidator()
        {
            RuleFor(b=>b.Id).GreaterThan(0).WithMessage("Id must be valid.");
            RuleFor(b=>b.Title).NotEmpty().WithMessage("Title is required.");
        }
    }
}