using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
namespace MediatRExample05
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello");
        var services = new ServiceCollection();
        services.AddMediatR(typeof(PingHandler).Assembly);
        var provider = services.BuildServiceProvider();

        var mediator = provider.GetRequiredService<IMediator>();
        var response = await mediator.Send(new Ping());
        Console.WriteLine(response);
    }
  }
}

