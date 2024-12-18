using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.DTOs
{
    public class CategoryDto
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> EventNames { get; set; } = new List<string>();
    }
}