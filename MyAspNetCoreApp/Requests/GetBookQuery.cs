using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Requests
{
    public class GetBookQuery:IRequest<Book>
    {
        public int Id { get; set; }
    }
}