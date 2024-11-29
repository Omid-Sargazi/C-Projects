// using MediatR;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.DependencyInjection;
// using MyAspNetCoreApp02.Requests;

// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddMediatR(typeof(Program));
// builder.Services.AddControllers();

// var app = builder.Build();

// app.MapPost("/api/payment/process", async (ProcessPaymentCommand command, IMediator mediator) =>
// {
//     var result = await mediator.Send(command);
//     return Results.Ok(result);
// });

// app.MapGet("/api/payment/status/{orderId}", async (int orderId, IMediator mediator) =>
// {
//     var query = new GetPaymentStatusQuery { OrderId = orderId };
//     var result = await mediator.Send(query);
//     return Results.Ok(result);
// });

// // app.MapControllers();
// app.Run();

// using MediatR;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Http;
// using MyAspNetCoreApp02.Requests;
// using MyAspNetCoreApp02.Requests.Book;

// var builder = WebApplication.CreateBuilder(args);

// // Register MediatR
// builder.Services.AddMediatR(typeof(Program));

// var app = builder.Build();

// // Add Book Endpoint
// app.MapPost("/api/library/add", async (AddBookCommand command, IMediator mediator) =>
// {
//     var result = await mediator.Send(command);
//     return Results.Ok(result);
// });

// // Borrow Book Endpoint
// app.MapPost("/api/library/borrow", async (BorrowBookCommand command, IMediator mediator) =>
// {
//     var result = await mediator.Send(command);
//     return Results.Ok(result);
// });

// // Check Book Availability Endpoint
// app.MapGet("/api/library/availability/{title}", async (string title, IMediator mediator) =>
// {
//     var query = new GetBookAvailabilityQuery { Title = title };
//     var result = await mediator.Send(query);
//     return Results.Ok(result);
// });

// app.Run();


using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MyAspNetCoreApp02.Requests.TaskManagementRequest;

using MediatR;
using MyAspNetCoreApp02.Requests.Customers;

// var builder = WebApplication.CreateBuilder(args);

// // Register MediatR
// builder.Services.AddMediatR(typeof(Program));

// var app = builder.Build();

// // Add Task Endpoint
// app.MapPost("/api/tasks/add", async (AddTaskCommand command, IMediator mediator) =>
// {
//     var result = await mediator.Send(command);
//     return Results.Ok(result);
// });

// // Update Task Status Endpoint
// app.MapPut("/api/tasks/update-status", async (UpdateTaskStatusCommand command, IMediator mediator) =>
// {
//     var result = await mediator.Send(command);
//     return Results.Ok(result);
// });

// // Get Tasks by Status Endpoint
// app.MapGet("/api/tasks/by-status/{status}", async (string status, IMediator mediator) =>
// {
//     var query = new GetTasksByStatusQuery { Status = status };
//     var tasks = await mediator.Send(query);
//     return Results.Ok(tasks);
// });

// app.Run();


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(Program));

var app=builder.Build();

app.MapPost("/api/customers",async(IMediator mediator, AddCustomerCommand command)=>{
    var result = await mediator.Send(command);
    return Results.Ok(result);
});


app.MapGet("/api/customers/{id}",async (IMediator mediator,Guid id)=>{
    try
    {
        var result = await mediator.Send(new GetCustomerByIdQuery {CustomerId=id});
        return Results.Ok(result);
    }
    catch(KeyNotFoundException ex){
        return Results.NotFound(ex.Message);
    }
});