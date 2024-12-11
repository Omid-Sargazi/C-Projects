using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Queries
{
    public record GetDepartmentByIdQuery(int Id):IRequest<DepartmentDto>;
}