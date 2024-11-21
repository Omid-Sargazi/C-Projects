using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR_Managment.Application.DTOs.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestRequest:IRequest<List<LeaveRequestDTo>>
    {
        
    }
}