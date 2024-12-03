using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwagger.DTOs;

namespace LibrarySystemSwagger.Validators
{
    public class BookUpdateDtoValidator:AbstractValidator<BookUpdateDto>
    {
        public BookUpdateDtoValidator()
        {
            RuleFor(b=>b.Id).GreaterThan(0).WithMessage("Id must be Valid.");
            RuleFor(b=>b.Title).NotEmpty().WithMessage("Title is required.");
        }
    }
}