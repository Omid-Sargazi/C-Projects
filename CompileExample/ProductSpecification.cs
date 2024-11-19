using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CompileExample
{
    public class ProductSpecification
    {
        public Expression<Func<Product,bool>> Criteria{get;}

        public ProductSpecification(decimal minimumPrice)
        {
            Criteria = product=>product.Price>=minimumPrice;
        }
    }
}