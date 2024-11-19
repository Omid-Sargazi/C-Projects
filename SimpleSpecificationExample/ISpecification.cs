using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSpecificationExample
{
    public interface ISpecification<T>
    {
        Expressions<Func<T,bool>> Criteria {get;}
        bool IsSatisfiedBy(T entity);        
    }
}