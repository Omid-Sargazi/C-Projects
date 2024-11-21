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
    public class GetLeaveAllocationRequestHandler:IRequestHandler<GetLeaveAllocationRequest,List<LeaveAllocationDTo>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveAllocationDTo>> Handle(GetLeaveAllocationRequest request,CancellationToken cancellationToken)
        {
            var leavListAllocation = await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveAllocationDTo>>(leavListAllocation);
        }
    }
}