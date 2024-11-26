using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using System;
using System.Threading.Tasks;
using MediatRExample05.Requests;
namespace MediatRExample05
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello");
        // var services = new ServiceCollection();
        // services.AddMediatR(typeof(PingHandler).Assembly);
        // var provider = services.BuildServiceProvider();

        // var mediator = provider.GetRequiredService<IMediator>();
        // var response = await mediator.Send(new Ping());
        // Console.WriteLine(response);

        // using var host = Host.CreateDefaultBuilder(args)
        //         .ConfigureServices((context, services) =>
        //         {
        //             services.AddApplicationServices(); // Register application services here
        //         })
        //         .Build();

        //     // Resolve the mediator
        //     var mediator = host.Services.GetRequiredService<IMediator>();

        //     // Send a request and print the response
        //     var response = await mediator.Send(new Ping());
        //     Console.WriteLine(response);

        using var host = Host.CreateDefaultBuilder(args)
        .ConfigureServices((context,services)=>{
            services.AddApplicationServices();
        })
        .Build();

        var mediator = host.Services.GetRequiredService<IMediator>();
         var response = await mediator.Send(new Greet("Omid"));
            Console.WriteLine(response); // Output: "Hello, Omid!"

    }
  }
}

