using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.Features.Department.Commands;
using LeaveManagement.Domain.Entities;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Handler
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new LeaveManagement.Domain.Entities.Department
            {
                Name=request.department.Name,
                Description = request.department.Description
            };

            await _unitOfWork.DepartmentRepository.AddAsync(department);
            await _unitOfWork.CommitAsync();
            return department.Id;
        }
        
    }
}