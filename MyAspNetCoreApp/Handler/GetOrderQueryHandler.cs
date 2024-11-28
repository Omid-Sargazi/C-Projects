using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, Order>
    {
        public Task<Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = OrderStore.orders.FirstOrDefault(o=>o.Id==request.Id);
            return Task.FromResult(order);
        }
    }
}