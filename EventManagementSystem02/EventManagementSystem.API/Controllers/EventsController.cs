using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventManagementSystem.API.Mappings;
using EventManagementSystem.Domain.Entities;
using EventManagementSystem.Infrastructure.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController:ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EventsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<EventDto>>> GetEvents()
        {
            var events = await _context.Events.Include(e=>e.Venue).ToListAsync();
            return Ok(_mapper.Map<List<EventDto>>(events));
        }

       [HttpPost]
public async Task<ActionResult> CreateEvent(EventDto eventDto)
{
    // Check if the venue exists
    var venue = await _context.Venues.FirstOrDefaultAsync(v => v.Name == eventDto.VenueName);
    if (venue == null)
    {
        return BadRequest($"Venue with name '{eventDto.VenueName}' does not exist.");
    }

    // Map the EventDto to Event
    var eventEntity = _mapper.Map<Event>(eventDto);
    eventEntity.VenueId = venue.Id; // Set VenueId from the database

    // Save the event
    _context.Events.Add(eventEntity);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetEvents), new { id = eventEntity.Id }, eventDto);
}

    }
}