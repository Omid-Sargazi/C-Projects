using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Features.LeaveRequest.Requests.Queries;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.Persistance.Contracts;
using MediatR;
using AutoMapper;

namespace HR_Managment.Application.DTOs.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestDetailsRequestHandler:IRequestHandler<GetLeaveRequestDetailsRequest,LeaveRequestDTo>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailsRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDTo> Handle(GetLeaveRequestDetailsRequest request,CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDTo>(leaveRequest);
        }
        
    }
}