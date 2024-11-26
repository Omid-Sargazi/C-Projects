using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Validators
{
    public class ProductValidator:AbstractValidator<AddProductRequest>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Product name is required");
            RuleFor(x=>x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }
}