using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using LibrarySystemBackend.DTOs;

namespace LibrarySystemBackend.Validators
{
    public class MemberCreateDtoValidator:AbstractValidator<MemberCreateDto>
    {
        public MemberCreateDtoValidator()
        {
            RuleFor(m=>m.Name).NotEmpty().WithMessage("Name is required.").MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");
            RuleFor(m=>m.Email).NotEmpty().WithMessage("Email is required.").EmailAddress().WithMessage("Invalid Email Format");
        }
    }
}