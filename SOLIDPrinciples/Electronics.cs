using System;

namespace MyNamespace
{
    public class Electronics:IProducts, IDiscountable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ApplyDiscount(decimal price) => price*0.9m;
    }
}