using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.DTOs
{
    public class OrganizerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<string> EventNames { get; set; } = new List<string>();
    }
}