using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        ITaskRepository taskRepository { get; }
        Task<int> CompleteAsync();
    }
}