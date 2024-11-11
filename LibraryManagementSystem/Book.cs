using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book:BookBase,IRentable
    {
        private decimal _price;
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public void SetPrice(decimal price)
        {
            if(price<=0)
            {
                throw new ArgumentException("Price must be positive.");
            }
            _price = price;
        }

        public override decimal GetPrice()
        {
            return _price;
        }

        public Rental Rent(Member member)
        {
            var rental = new Rental{
                Book=this,
                Member=member,
                RentalDate=DateTime.Now,
            };
            return rental;
        }
    }
}