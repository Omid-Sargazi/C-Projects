using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HR_Managment.Application.DTOs.LeaveType;

namespace HR_Managment.Application.DTOs.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDTo>
    {
        public int Id { get; set; }
    }
}