using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp02.Requests;

namespace MyAspNetCoreApp02.controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController:ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("{id}/price")]
        public async Task<IActionResult> UpdatePrice(int id,[FromBody] decimal newPrice)
        {
            var result = await _mediator.Send(new UpdateProductPriceCommand {ProductId=id,NewPrice=newPrice});
            return Ok(result);
        }
    }
}