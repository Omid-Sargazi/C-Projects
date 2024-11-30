// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();

// using DIWebServer02.Interfaces;
// using DIWebServer02.Interfaces.Logger;

// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddTransient<IGreeterService,GreeterService>();
// builder.Services.AddControllers();

// var app = builder.Build();

// app.UseRouting();
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapControllers();
// });
// app.Run();

using DIWebServer02.Interfaces.Logger;

namespace DIWebServer02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogger02 logger = new ConsoleLogger();
            BusinessService service = new BusinessService(logger);
            service.PerformTask();
        }
    }
}