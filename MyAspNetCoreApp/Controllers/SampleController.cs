using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Requests;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddBook([FromBody] AddBookCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBook(int id)
    {
        var query = new GetBookQuery { Id = id };
        var result = await _mediator.Send(query);
        return result != null ? Ok(result) : NotFound("Book not found");
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateBook([FromBody] UpdateBookCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var command = new DeleteBookCommand { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
