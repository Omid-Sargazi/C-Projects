using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using MediatRExample03.Commands;
using MediatRExample03.Handlers;
using MediatR;

namespace MediatRExample03

{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            var provider = services.BuildServiceProvider();
            var mediator = provider.GetRequiredService<IMediator>();

            var createUserCommand = new CreateUserCommand { UserName = "Omid" };
        var createResult = await mediator.Send(createUserCommand);
        Console.WriteLine(createResult);

        // Sending DeleteUserCommand
        var deleteUserCommand = new DeleteUserCommand { UserName = "Omid" };
        var deleteResult = await mediator.Send(deleteUserCommand);
        Console.WriteLine(deleteResult);

        }
    }
}