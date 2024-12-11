using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.Leaves.Commands;
using LeaveManagement.Application.Features.Leaves.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveController:ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeave([FromBody] LeaveDto leaveDto)
        {
            var leavedId = await _mediator.Send(new CreateLeaveCommand(leaveDto));
            return Ok(leavedId);
        }

        [HttpGet]
        public async Task<IActionResult> GetLeaves()
        {
            var leave = await _mediator.Send(new GetLeavesQuery());
            return Ok(leave);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeave(int id,[FromBody] string status)
        {
            var result = await _mediator.Send(new UpdateLeaveCommand(id,status));
            return Ok(status);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeave(int id)
        {
            var result = await _mediator.Send(new DeleteLeaveCommand(id));
            return Ok(result);
        }
    }
}