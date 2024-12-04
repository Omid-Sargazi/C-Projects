using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwaggers.DTOs;

namespace LibrarySystemSwaggers.Validators
{
    public class BookUpdateDtoValidator:AbstractValidator<BookUpdateDto>
    {
        public BookUpdateDtoValidator()
        {
            RuleFor(b=>b.Id).NotEmpty().WithMessage("Id must be valid").GreaterThanOrEqualTo(0).WithMessage("Id must be greater than zero").NotNull().WithMessage("{PropertyName} must nut null");
            RuleFor(b=>b.Title).NotEmpty().WithMessage("This is required");
        }
    }
}