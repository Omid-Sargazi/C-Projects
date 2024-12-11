using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.Department.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.Department.Handler
{
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetDepartmentByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _unitOfWork.DepartmentRepository.GetByIdAsync(request.Id);
            if(department == null)
            {
                throw new KeyNotFoundException("Department not found");
            }

            return new DepartmentDto
            {
                Name=department.Name,
                Description=department.Description,
            };
        }
    }
}