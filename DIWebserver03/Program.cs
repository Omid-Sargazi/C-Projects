using DIWebserver03.Business;
using DIWebserver03.Implements;
using DIWebserver03.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// ILoggers loggers = new ConsoleLogger();
// BusinessService business = new BusinessService(loggers);
// business.performTask("omid");

// ILoggers loggers = new ConsoleLogger();
// BusinessServiceProperty businessServiceProperty = new BusinessServiceProperty();
// businessServiceProperty.loggers1 = loggers;
// businessServiceProperty.PerformTask();

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ILoggers,ConsoleLogger>();
serviceCollection.AddTransient<BusinessService>();
var serviceProvider = serviceCollection.BuildServiceProvider();
var service = serviceProvider.GetService<BusinessService>();
service.performTask("hi");




app.Run();
