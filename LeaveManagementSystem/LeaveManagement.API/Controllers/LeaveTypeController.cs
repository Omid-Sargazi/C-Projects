using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.Leaves.Queries;
using LeaveManagement.Application.Features.LeaveType.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveTypeController:ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeaveType([FromBody] LeaveTypeDto leaveTypeDto)
        {
            var result = await _mediator.Send(new CreateLeavesTypeCommand(leaveTypeDto));
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetLeaveTypes()
        {
            var result = await _mediator.Send(new GetLeavesQuery());
            return Ok(result);
        }
    }
}