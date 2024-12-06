using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using FluentValidation;

namespace Application.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.Name).NotEmpty().WithMessage("Product name is required.");
            RuleFor(p=>p.Description).NotEmpty().WithMessage("Product name is required.");
            RuleFor(p=>p.Price).NotEmpty().WithMessage("Price must be greater than zero.");
            RuleFor(p=>p.Stock).NotEmpty().WithMessage("Stock cannot be negative.");

        }
    }
}