using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace LeaveManagement.Application.DTOs
{
    public class LeaveValidator:AbstractValidator<LeaveDto>
    {
        public LeaveValidator()
        {
            RuleFor(x => x.EmployeeId).NotEmpty().WithMessage("Employee ID is required.");
            RuleFor(x => x.StartDate).LessThan(x => x.EndDate).WithMessage("Start Date must be before End Date.");
            RuleFor(x => x.Reason).NotEmpty().MaximumLength(250).WithMessage("Reason is required and must be under 250 characters.");
        }
    }
}