using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries
{
    public class GetAllProductsQuery:IRequest<List<Product>>
    {
        
    }
}