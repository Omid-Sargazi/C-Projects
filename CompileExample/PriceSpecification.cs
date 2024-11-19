using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CompileExample
{
    public class PriceSpecification:ISpecification<Product>
    {
        private readonly decimal _minPrice;

        public PriceSpecification(decimal minPrice)
        {
            _minPrice = minPrice;
        }

        public Expression<Func<Product,bool>> Criteria=>product=>product.Price>=minPrice;

        public bool IsSatisfiedBy(Product product)
        {
            return product.Price>=_minPrice;
        }
    }
}