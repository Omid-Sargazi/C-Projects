using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyAspNetCoreApp.Handler;

var builder = WebApplication.CreateBuilder(args);

// Register MediatR
builder.Services.AddMediatR(typeof(AddBookCommandHandler).Assembly);

// Register controllers
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
