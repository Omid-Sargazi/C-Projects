using System;
namespace Repository
{
    public class Entity
    {
        public int Id{ get; set; }
    }

    public class Product: Entity
    {
        public string Name{ get; set; }
        public string Price { get; set; }
    }

    public class Customer: Entity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }


}