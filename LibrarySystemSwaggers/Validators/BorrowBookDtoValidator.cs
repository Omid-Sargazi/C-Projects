using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwaggers.Models;

namespace LibrarySystemSwaggers.Validators
{
    public class BorrowBookDtoValidator:AbstractValidator<BorrowBookDto>
    {
        public BorrowBookDtoValidator()
        {
             RuleFor(b => b.MemberId)
            .GreaterThan(0).WithMessage("Invalid Member ID.");

        RuleFor(b => b.BookId)
            .GreaterThan(0).WithMessage("Invalid Book ID.");

        RuleFor(b => b.DueDate)
            .GreaterThan(DateTime.Now).WithMessage("Due date must be in the future.");
        }
    }
}