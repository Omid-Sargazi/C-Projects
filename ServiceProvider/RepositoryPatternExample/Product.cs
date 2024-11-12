using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider.RepositoryPatternExample
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrdreItem> OrderItems { get; set; } = new List<OrdreItem>();
    }
}