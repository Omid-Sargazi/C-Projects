using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Application.DTOs;
using Application.Features.Books.Commands;
using Application.Features.Books.Queries;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;


namespace API.Controllers
{
    public class BookController:ControllerBase
    {
        private readonly IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateBook([FromBody] BookDTO bookDTO)
    {
        var command = new CreateBookCommand { Book = bookDTO };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetBooks()
    {
        var query = new GetBooksQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    }
}