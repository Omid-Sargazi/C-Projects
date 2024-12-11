using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace LeaveManagement.Application.DTOs
{
    public class LeaveTypeValidator:AbstractValidator<LeaveTypeDto>
    {
        public LeaveTypeValidator()
        {

        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(x => x.Description).MaximumLength(500).WithMessage("Description must be under 500 characters.");
        }
    }
}