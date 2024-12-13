using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int AttendeeId { get; set; }
        public string TicketType { get; set; } // e.g., "Regular", "VIP"
        public decimal Price { get; set; }
    }
}