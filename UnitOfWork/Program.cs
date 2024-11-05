using System;

namespace UnitOfWOrk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    public class Product
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int Stock{get;set;}
    }

    public class Order
    {
        public int Id{get;set;}
        public int ProductId{get;set;}
        public int Quantity{get;set;}
        
    }

    public class Customer
    {
        public int Id{get;set;}
        public string Name {get;set;}
        public decimal Balance{get;set;}
    }
}