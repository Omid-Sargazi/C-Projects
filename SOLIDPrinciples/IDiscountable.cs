using System;
namespace MyNamespace
{
    public interface IDiscountable
    {
        decimal ApplyDiscount(decimal price);
    }
}