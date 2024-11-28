// using MediatR;
// using Microsoft.AspNetCore.Mvc;
// using MyAspNetCoreApp.Requests;
// using System.Threading.Tasks;

// [ApiController]
// [Route("api/[controller]")]
// public class OrderController : ControllerBase
// {
//     private readonly IMediator _mediator;

//     public OrderController(IMediator mediator)
//     {
//         _mediator = mediator;
//     }

//     [HttpPost("create")]
//     public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
//     {
//         var result = await _mediator.Send(command);
//         return Ok(result);
//     }

//     [HttpGet("{id}")]
//     public async Task<IActionResult> GetOrder(int id)
//     {
//         var result = await _mediator.Send(new GetOrderQuery { Id = id });
//         return result != null ? Ok(result) : NotFound($"Order with ID {id} not found.");
//     }

//     [HttpPut("{id}/status")]
//     public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] string newStatus)
//     {
//         var result = await _mediator.Send(new UpdateOrderStatusCommand { Id = id, NewStatus = newStatus });
//         return Ok(result);
//     }

//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeleteOrder(int id)
//     {
//         var result = await _mediator.Send(new DeleteOrderCommand { Id = id });
//         return Ok(result);
//     }
// }

using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Requests;
using System.Threading.Tasks;


[ApiController]
[Route("api/[controller]")]
public class OrderController:ControllerBase
{
    private readonly IMediator _mediator;
    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var result = await _mediator.Send( new GetOrderQuery{Id=id});
        return result !=null ?Ok(result):NotFound($"Order with ID {id} not found.");
    }

    [HttpPut("{id}/ststus")]
    public async Task<IActionResult> UpdateOrderStatus(int id,[FromBody] string newStatus)
    {
        var result = await _mediator.Send(new UpdateOrderStatusCommand {Id=id, NewStatus=newStatus});
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrder(int id)
    {
        var result = await _mediator.Send(new DeleteOrderCommand {Id=id});
        return Ok(result);
    }
}