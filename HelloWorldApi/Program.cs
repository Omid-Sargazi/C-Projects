using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Define a simple endpoint for the "Hello World" API
app.MapGet("/hello", () => Results.Ok("Hello World"));

app.Run();
