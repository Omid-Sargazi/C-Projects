using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Books.Commands;
using Core.Entities;
using FluentValidation;

namespace Application.Features.Validators
{
    public class AddBookValidator:AbstractValidator<AddBookCommand>
    {
        public AddBookValidator()
        {
            RuleFor(b=>b.Book.Title).NotEmpty();
            RuleFor(b=>b.Book.Author).NotEmpty();
            RuleFor(b=>b.Book.PublishedDate).LessThanOrEqualTo(DateTime.Now);
        }
    }
}