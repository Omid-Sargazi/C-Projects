using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.Features.Department.Commands;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Handler
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteDepartmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _unitOfWork.DepartmentRepository.GetByIdAsync(request.Id);
            if (department == null)
            {
                throw new KeyNotFoundException("Department not found");
            }
            
            _unitOfWork.DepartmentRepository.Delete(department);
            await _unitOfWork.CommitAsync();
            return true;
        }
    }
}