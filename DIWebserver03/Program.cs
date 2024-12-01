

using DIWebserver03.LoggerExample;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);


// ILoggers loggers = new ConsoleLogger();
// BusinessService business = new BusinessService(loggers);
// business.performTask("omid");

// ILoggers loggers = new ConsoleLogger();
// BusinessServiceProperty businessServiceProperty = new BusinessServiceProperty();
// businessServiceProperty.loggers1 = loggers;
// businessServiceProperty.PerformTask();

// var serviceCollection = new ServiceCollection();
// serviceCollection.AddTransient<ILoggers,ConsoleLogger>();
// serviceCollection.AddTransient<BusinessService>();
// var serviceProvider = serviceCollection.BuildServiceProvider();
// var service = serviceProvider.GetService<BusinessService>();
// service.performTask("hi");
builder.Services.AddTransient<ILoggerMain,ConsoleLogger>();
builder.Services.AddTransient<BusinessService>();

var app = builder.Build();

app.MapGet("/", (BusinessService service) => {
    service.PerformTask();
    return Results.Ok("Task performed");
    
    });






app.Run();
