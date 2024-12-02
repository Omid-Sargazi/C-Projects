using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemBackend.DTOs;

namespace LibrarySystemBackend.Validators
{
    public class BookUpdateDtoValidator:AbstractValidator<BookUpdateDto>
    {
        public BookUpdateDtoValidator()
        {
            RuleFor(b=>b.Id).GreaterThan(0).WithMessage("Id must be valid.");
            RuleFor(B=>B.Title).NotEmpty().WithMessage("Title is required.");
        }
    }
}