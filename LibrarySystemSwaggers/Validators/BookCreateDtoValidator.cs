using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwaggers.DTOs;

namespace LibrarySystemSwaggers.Validators
{
    public class BookCreateDtoValidator:AbstractValidator<BookCreateDto>
    {
        public BookCreateDtoValidator()
        {
            RuleFor(b=>b.Title).NotEmpty().WithMessage("Title is required").NotNull().WithMessage("Tile must be.");
            RuleFor(b=>b.PublishedDate).LessThanOrEqualTo(DateTime.Now).WithMessage("Published date connot be in the future");
        }
    }
}