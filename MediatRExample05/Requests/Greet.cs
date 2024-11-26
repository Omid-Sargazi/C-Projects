using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;


namespace MediatRExample05.Requests
{
    public class Greet:IRequest<string>
    {
        public string Name { get; set; }
        public Greet(string name)
        {
            Name = name;
        }
    }
}