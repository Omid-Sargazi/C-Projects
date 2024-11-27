using FluentValidation;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IValidator<Pesron>, PersonValidator>();
builder.Services.AddMediatR(typeof(Program));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
