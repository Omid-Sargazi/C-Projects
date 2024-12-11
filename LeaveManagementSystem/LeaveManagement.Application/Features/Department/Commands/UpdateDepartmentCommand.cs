using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Commands
{
    public record UpdateDepartmentCommand(int Id,String Name, string Description):IRequest<bool>;
}