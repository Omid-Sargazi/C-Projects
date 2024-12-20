using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Domain.Entities
{
    public class Venue
    {
         public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Event> Events { get; set; } = new();
    }
}