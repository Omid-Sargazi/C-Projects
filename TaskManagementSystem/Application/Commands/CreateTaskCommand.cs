using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Application.Commands
{
    public class CreateTaskCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}