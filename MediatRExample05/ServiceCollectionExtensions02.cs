using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace MediatRExample05
{
    public static class ServiceCollectionExtensions02
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}