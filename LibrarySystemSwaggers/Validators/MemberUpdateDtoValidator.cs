using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemSwaggers.Models;

namespace LibrarySystemSwaggers.Validators
{
    public class MemberUpdateDtoValidator:AbstractValidator<MemberUpdateDto>
    {
        public MemberUpdateDtoValidator()
        {
            RuleFor(m => m.Id).GreaterThan(0).WithMessage("Invalid Member ID.");

        RuleFor(m => m.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");

        RuleFor(m => m.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");
        }
    }
}