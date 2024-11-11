using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class EBook:BookBase
    {
        public string Format {get;set;}
        private decimal _price;
        public void SetPrice(decimal price)
        {
            if(price <= 0)
            {
                throw new ArgumentException("Price must be positive.");
            }
            _price=price;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}