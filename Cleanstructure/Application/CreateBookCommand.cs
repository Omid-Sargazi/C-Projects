using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
namespace Cleanstructure.Application
{
    public class CreateBookCommand:IRequest<int>
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}