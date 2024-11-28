// using MediatR;
// using Microsoft.Extensions.DependencyInjection;
// using MyAspNetCoreApp.Handler;

// var builder = WebApplication.CreateBuilder(args);

// // Register MediatR
// builder.Services.AddMediatR(typeof(AddBookCommandHandler).Assembly);

// // Register controllers
// builder.Services.AddControllers();

// var app = builder.Build();

// app.MapControllers();

// app.Run();


using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Register controllers and MediatR
builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

app.MapControllers();
app.Run();
;