using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, string>
    {

        public Task<string> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newOrder = new Order
            {
                Id=OrderStore.orders.Count+1,
                ProductName=request.ProductName,
                Quantity=request.Quantity,
                
            };

            OrderStore.orders.Add(newOrder);
            return Task.FromResult($"Order '{newOrder.ProductName}' created with ID {newOrder.Id}.");
        }
    }
}