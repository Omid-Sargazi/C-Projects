using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwagger.DTOs;

namespace LibrarySystemSwagger.Validators
{
    public class BookCreateDtoValidator:AbstractValidator<BookCreateDto>
    {
        public BookCreateDtoValidator()
        {
            RuleFor(p=>p.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(b=>b.PublishedDate).NotEmpty().WithMessage("Published Date is requred.").LessThanOrEqualTo(DateTime.Now).WithMessage("Published Date cannot be in the future");
            
        }
    }
}