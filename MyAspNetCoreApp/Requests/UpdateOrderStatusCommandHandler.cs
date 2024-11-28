using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp.Requests
{
    public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, string>
    {
        public Task<string> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var order = OrderStore.orders.FirstOrDefault(o=>o.Id==request.Id);
            if(order==null)
            {
                return Task.FromResult($"Order with ID {request.Id} not found.");
            }
            order.Status=request.NewStatus;
            return Task.FromResult($"Order {order.Id} status updated to '{order.Status}'.");
        }

    }
}