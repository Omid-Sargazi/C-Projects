using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Features.Leaves.Commands;
using MediatR;

namespace LeaveManagement.Application.Features.Leaves.Handlers
{
    public class CreateLeaveCommandHandler : IRequestHandler<CreateLeaveCommand, int>
    {
        public Task<int> Handle(CreateLeaveCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}