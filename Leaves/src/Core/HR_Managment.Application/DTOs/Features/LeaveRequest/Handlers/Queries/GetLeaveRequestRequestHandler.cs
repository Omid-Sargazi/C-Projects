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
    public class GetLeaveRequestRequestHandler:IRequestHandler<GetLeaveRequestRequest,List<LeaveRequestDTo>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public GetLeaveRequestRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper=mapper;
        }

        public async Task<List<LeaveRequestDTo>> Handle(GetLeaveRequestRequest request,CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDTo>>(leaveRequest);
        }
    }
}