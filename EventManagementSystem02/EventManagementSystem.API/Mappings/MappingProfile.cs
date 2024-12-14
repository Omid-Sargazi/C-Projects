using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventManagementSystem.Domain.Entities;

namespace EventManagementSystem.API.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Event,EventDto>().ReverseMap();
            CreateMap<Venue,VenueDto>().ReverseMap();
        }
    }

    public class EventDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? VenueName { get; set; }
    }

    public class VenueDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}