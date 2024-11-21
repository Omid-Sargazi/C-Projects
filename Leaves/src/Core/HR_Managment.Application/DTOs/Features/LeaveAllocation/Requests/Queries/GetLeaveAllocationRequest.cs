using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HR_Managment.Application.DTOs.LeaveAllocation;

namespace HR_Managment.Application.DTOs.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationRequest:IRequest<List<LeaveAllocationDTo>>
    {
        
    }
}