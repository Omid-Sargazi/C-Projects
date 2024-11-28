using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, string>
    {
        public Task<string> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var order = OrderStore.orders.FirstOrDefault(o=>o.Id==request.Id);
            if(order==null)
            {
                return Task.FromResult($"Order with ID {request.Id} not found.");
            }
            OrderStore.orders.Remove(order);
            return Task.FromResult($"Order {order.Id} deleted.");
        }
    }
}