using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MediatRExample
{

class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        
         services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));


        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        // Create a command and send it
        var command = new CreateUserCommand { UserName = "Omid" };
        var result = await mediator.Send(command);

        Console.WriteLine(result);

    }

}
}