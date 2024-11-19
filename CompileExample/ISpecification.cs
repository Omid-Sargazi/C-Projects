using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CompileExample
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria { get; }
        bool IsSatisfiedBy(T entity);
    }
}