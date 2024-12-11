using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.Features.Department.Commands;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Handler
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateDepartmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _unitOfWork.DepartmentRepository.GetByIdAsync(request.Id);
            if(department==null)
                throw new KeyNotFoundException("Department not found");
            department.Name=request.Name;
            department.Description=request.Description;
            _unitOfWork.DepartmentRepository.Update(department);
            await _unitOfWork.CommitAsync();
            return true;
        }
    }
}