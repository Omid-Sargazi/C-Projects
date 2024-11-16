﻿using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using MediatRExample04.Commands;

namespace MediatRExample04
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello");
            var services = new ServiceCollection();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            var provider = services.BuildServiceProvider();
            var mediator = provider.GetRequiredService<IMediator>();

            var command = new CreateUserCommand{UserName="Omid"};
            var result = await mediator.Send(command);
            Console.WriteLine(""+ result);
        }
    }
}