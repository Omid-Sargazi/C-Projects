using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string AttendeeName { get; set; }
        public string TicketType { get; set; }
        public decimal Price { get; set; }
    }
}