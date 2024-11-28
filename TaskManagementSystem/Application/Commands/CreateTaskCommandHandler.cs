using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Application.Commands
{
    public class CreateTaskCommandHandler:IRequestHandler<CreateTaskCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTaskCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }

        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new Task(request.Title,request.Description,request.Status);
            var taskId = await _unitOfWork.TaskRepository.AddTaskAsync(task);
            await _unitOfWork.CompleteAsync(); 
            return taskId;
        }
    }
}