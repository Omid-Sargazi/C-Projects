using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using AutoMapper;
using MediatR;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Application.Features.Books.Commands;
// using AutoMapper.Extensions.Microsoft.DependencyInjection;


namespace API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Connection_String"));
    services.AddScoped<IUnitOfWork, UnitOfWork>();

    // Configure AutoMapper with a single configuration action.
    services.AddAutoMapper(typeof(AutoMapperProfile));  // This is the correct way


    services.AddMediatR(typeof(CreateBookHandler).Assembly);
    services.AddControllers();
}


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}

}