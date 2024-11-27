using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Validators
{
    public class PersonValidator:AbstractValidator<Pesron>
    {
        public PersonValidator()
        {
            RuleFor(p=>p.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Invalid email address.");
            RuleFor(p => p.Age).Must(age => age % 2 == 0).WithMessage("Age must be an even number.");

        }
    }
}