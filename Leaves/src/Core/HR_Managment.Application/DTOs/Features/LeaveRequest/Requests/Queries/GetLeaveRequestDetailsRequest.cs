using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HR_Managment.Application.DTOs.LeaveRequest;


namespace HR_Managment.Application.DTOs.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestDetailsRequest:IRequest<LeaveRequestDTo>
    {
        public int Id { get; set; }
    }
}