using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Domain.Entities;

namespace LeaveManagement.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        GenericRepository<Leave> LeaveRepository { get; }
        Task CommitAsync();
    }
}