using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Features.LeaveAllocation.Requests.Queries;
using HR_Managment.Application.DTOs.LeaveAllocation;
using HR_Managment.Application.Persistance.Contracts;

using MediatR;
using AutoMapper;

namespace HR_Managment.Application.DTOs.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequestHandler:IRequestHandler<GetLeaveAllocationDetailRequest,LeaveAllocationDTo>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDTo> Handle(GetLeaveAllocationDetailRequest request,CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDTo>(leaveAllocation);
        }
    }
}