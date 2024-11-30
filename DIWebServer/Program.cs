// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();


using DIWebServer.Handler;
using DIWebServer.Impementations;
using DIWebServer.Interfaces;

// namespace DIWebServer
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             IGreeterService greeterService = new GreeterService();
//             var handler = new WebRequestHandler(greeterService);
//             handler.HandleRequest("Omid");
//         }
//     }
// }

var builder = WebApplication.CreateBuilder(args);

// Register your services here
builder.Services.AddTransient<IGreeterService, GreeterService>();

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
