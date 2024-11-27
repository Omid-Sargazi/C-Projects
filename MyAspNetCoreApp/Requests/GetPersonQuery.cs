using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Requests
{
    public class GetPersonQuery:IRequest<Pesron>
    {
        public int Id { get; set; }
    }
}