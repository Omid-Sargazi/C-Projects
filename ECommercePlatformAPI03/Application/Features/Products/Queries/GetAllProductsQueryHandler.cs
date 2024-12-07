using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _repositoey;

        public GetAllProductsQueryHandler(IProductRepository repository)
        {
            _repositoey = repository;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _repositoey.GetAllProductsAsync(cancellationToken);
            return products;
        }
    }
}