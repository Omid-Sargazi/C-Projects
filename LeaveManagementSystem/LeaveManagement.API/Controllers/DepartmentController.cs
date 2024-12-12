using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.Department.Commands;
using LeaveManagement.Application.Features.Department.Queries;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController: ControllerBase
    {
        private readonly IMediator _mediator;
        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

       [HttpPost]
    public async Task<IActionResult> CreateDepartment([FromBody] DepartmentDto departmentDto)
    {
        var result = await _mediator.Send(new CreateDepartmentCommand(departmentDto));
        return Ok(result);
    }
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var result = await _mediator.Send(new GetDepartmentsQuery());
            return Ok(result);
        }
    }
}