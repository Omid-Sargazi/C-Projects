using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
namespace MediatRExample02
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMediatR(typeof(Program).Assembly);

            var provider = services.BuildServiceProvider();
            var mediator = provider.GetRequiredService<IMediator>();

            var command = new CreateUserCommand { UserName = "Omid" };
            var result = await mediator.Send(command);

            Console.WriteLine(result);


        }
    }
}