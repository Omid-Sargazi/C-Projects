using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Commands
{
    public record DeleteDepartmentCommand(int Id):IRequest<bool>;
}