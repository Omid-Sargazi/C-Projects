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
    public class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, List<DepartmentDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetDepartmentsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DepartmentDto>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
            return departments.Select(d=>new DepartmentDto
            {
                Name=d.Name,
                Description=d.Description,
            }).ToList();
        }
    }
}