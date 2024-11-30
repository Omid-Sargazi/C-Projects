using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIWebServer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIWebServer.controller
{
   [ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    private readonly IGreeterService _greeterService;

    public GreetingController(IGreeterService greeterService)
    {
        _greeterService = greeterService;
    }

    [HttpGet("{name}")]
    public IActionResult Greet(string name)
    {
        var message = _greeterService.Greet(name);
        return Ok(message);
    }
}

}