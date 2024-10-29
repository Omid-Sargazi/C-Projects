using   System;
using System.Collections.Generic;
using System.Linq;
namespace MyNamespace
{
    public interface IProduct
    {
        int Id{get;}
        string Name{get;}
    }

    public interface IDiscountable
    {
        decimal ApplyDiscount(decimal price);
    }

    
}