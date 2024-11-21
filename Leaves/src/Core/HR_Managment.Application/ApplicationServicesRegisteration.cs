using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection; // Corrected namespace

using System.Reflection;

namespace HR_Managment.Application
{
    public static class ApplicationServicesRegisteration
    {
        public static void CofigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(cfg => {}, Assembly.GetExecutingAssembly());
            //dotnet add src/Core/HR_Managment.Application/HR_Managment.Application.csproj package AutoMapper.Extensions.Microsoft.DependencyInjection


        }
    }
}