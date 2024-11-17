using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<int> AddTaskAsync(Task task);
        Task<List<Task>> GetAllTasksAsync();
        Task<Task> GetTaskByIdAsync(int id);
        Task UpdateTaskAsync(Task task);
        Task DeleteTaskAsync(int id);
    }
}