using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using HR_Managment.Application.DTOs.Features.LeaveType.Requests.Queries;
using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Application.Persistance.Contracts;

namespace HR_Managment.Application.DTOs.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler: IRequestHandler<GetLeaveTypeDetailRequest,LeaveTypeDTo>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository= leaveTypeRepository;
            _mapper= mapper;
        }
        public async Task<LeaveTypeDTo> Handle(GetLeaveTypeDetailRequest request,CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDTo>(leaveType);
        }
    }
}