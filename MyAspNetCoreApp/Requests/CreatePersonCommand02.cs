using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp.Requests
{
    public class CreatePersonCommand02:IRequest<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public int Age { get; set; }
    }
}