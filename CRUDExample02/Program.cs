using CRUDExample02.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(Options=>Options.UseSqlite("Data Source=app.db"));

builder.Services.AddControllers();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
