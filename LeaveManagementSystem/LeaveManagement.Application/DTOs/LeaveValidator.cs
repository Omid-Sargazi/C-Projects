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
            RuleFor(x=>x.EmployeeId).NotEmpty().WithMessage("Id is required.");
            RuleFor(x=>x.StartDate).LessThan(x=>x.EndDate).WithMessage("Start date must be less than end date.");
            RuleFor(x=>x.Reason).NotEmpty().WithMessage("Reason must be and is required").MaximumLength(50).WithMessage("Length of message must be less than 250 character.");
        }
    }
}