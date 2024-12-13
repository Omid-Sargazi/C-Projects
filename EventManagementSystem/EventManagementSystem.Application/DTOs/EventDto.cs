using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string VenueName { get; set; }
        public string OrganizerName { get; set; }
        public List<string> AttendeeNames { get; set; } = new List<string>();
    }
}