using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;   
using HR_Managment.Application.DTOs.Features.LeaveType.Requests.Queries;
using HR_Managment.Application.DTOs.LeaveType;
using MediatR;
using HR_Managment.Application.Persistance.Contracts;

namespace HR_Managment.Application.DTOs.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeRequestHandler:IRequestHandler<GetLeaveTypeRequest,List<LeaveTypeDTo>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeRequestHandler(ILeaveTypeRepository _leaveTypeRepository
,IMapper mapper)
{
    _leaveTypeRepository = _leaveTypeRepository;
    _mapper = mapper;
}
        public async Task<List<LeaveTypeDTo>> Handle(GetLeaveTypeRequest request,CancellationToken cancellationToken)
        {
            var LeaveTypeList = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDTo>>(LeaveTypeList);
            //throw new NotImplementedException();
        }
    }
}