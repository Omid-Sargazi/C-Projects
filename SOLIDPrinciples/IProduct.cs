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

    public class Electronics:IProduct, IDiscountable
    {
        public int Id{get;set;}
        public string Name{get;set}
        public decimal ApplyDiscount(decimal price)=>price *0.9m;
    }

    public class Grocery:IProduct
    {
        public int Id{get; set;}
        public string Name{get;set;}
    }
    
}