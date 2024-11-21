using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.DTOs.Features.LeaveRequest.Requests.Queries;
using HR_Managment.Application.Persistance.Contracts;

namespace HR_Managment.Application.DTOs.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestRequestHandler:IRequestHandler<GetLeaveRequestRequest,List<LeaveRequesListDTo>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public GetLeaveRequestRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper=mapper;
        }

        public async Task<List<LeaveRequesListDTo>> Handle(GetLeaveRequestRequest request,CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveRequesListDTo>>(leaveRequest);
        }
    }
}