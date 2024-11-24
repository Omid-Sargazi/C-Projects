// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace CSharp.LibrarySystemClean.API
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Hello");
//         }
//     }
// }


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
