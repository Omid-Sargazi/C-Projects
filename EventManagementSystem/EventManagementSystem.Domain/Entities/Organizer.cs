using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Domain.Entities
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<int> EventIds { get; set; }= new List<>();

    }
}