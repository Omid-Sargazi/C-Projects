using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Domain.Entities;
using LeaveManagement.Infrastructure.Persistence;

namespace LeaveManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private GenericRepository<Leave> _leaveRepository;
        private GenericRepository<Department> _departmentRepository;
        private GenericRepository<Employee> _employeeRepository;
        private GenericRepository<LeaveType> _leaveTypeRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public IGenericRepository<Leave> LeaveRepository => _leaveRepository ??= new GenericRepository<Leave>(_context);
        public IGenericRepository<Employee> EmployeeRepository => _employeeRepository ??= new GenericRepository<Employee>(_context);
        public IGenericRepository<LeaveType> LeaveTypeRepository => _leaveTypeRepository ??= new GenericRepository<LeaveType>(_context);

        public IGenericRepository<Department> DepartmentRepository => _departmentRepository ??= new GenericRepository<Department>(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}