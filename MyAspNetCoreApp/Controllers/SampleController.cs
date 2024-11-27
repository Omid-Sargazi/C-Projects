using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Requests;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public PersonController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePersonCommand02 command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPerson(int id)
    {
        var query = new GetPersonQuery { Id = id };
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdatePerson([FromBody] UpdatePersonCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var command = new DeletePersonCommand { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
