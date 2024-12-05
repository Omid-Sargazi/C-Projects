using ECommerceSystemSwagger.Models;
using ECommerceSystemSwagger.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Add Controllers
builder.Services.AddControllers();

// Add Swagger (optional for debugging and API exploration)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Ensure the database is created and seed data if necessary
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<LibraryContext>();
    context.Database.EnsureCreated();

    // Seed data if empty
    if (!context.Products.Any())
    {
        context.Categories.Add(new Category { Name = "Electronics" });
        context.Products.Add(new Product
        {
            Name = "Smartphone",
            Price = 599.99M,
            Stock = 100,
            Description = "A high-end smartphone.",
            CategoryId = 1
        });

        context.Users.Add(new User
        {
            Username = "john_doe",
            Email = "john@example.com"
        });

        context.SaveChanges();
    }
}

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
