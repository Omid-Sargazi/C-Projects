using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using FluentValidation.Results;
using System;
using MyAspNetCoreApp.Models;

// [ApiController]
// [Route("api/custom-route")]
// public class SampleController : ControllerBase
// {
//     private readonly IValidator<Pesron> _validator;

//     public SampleController(IValidator<Pesron> validator)
//     {
//         _validator = validator;
//     }


//     [HttpGet]
//     public IActionResult ValidatePerson([FromBody] Pesron person)
//     {
        
//          ValidationResult result = _validator.Validate(person);

//         if (!result.IsValid)
//         {
//             return BadRequest(result.Errors);
//         }

//         return Ok("Person is valid!");
//     }
// }

// SampleController.cs
using MediatR;
// using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Requests;

[Route("api/[controller]")]
[ApiController]
public class SampleController : ControllerBase
{
    private readonly IMediator _mediator;

    public SampleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create-person")]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePersonCommand02 command)
    {
        var result = await _mediator.Send(command);  // Send the command using MediatR
        return Ok(result);
    }
}



// [ApiController]
// [Route("api/custom-route")]
// public class SampleController : ControllerBase
// {
//     [HttpPost]
//     public IActionResult ValidatePerson([FromBody] Pesron person)
//     {
//         // Validation logic here
//         return Ok("Person is valid!");
//     }
// }
