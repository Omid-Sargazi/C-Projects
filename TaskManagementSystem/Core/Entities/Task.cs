using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Entities
{
    public class Task
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Status { get; private set; }

        public Task(string title, string description, string status)
        {
            if(string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException("title is required.");
            if(string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Description is required.");
            Title = title;
            Description = description;
            static = status;
        }

        public void UpdateTask(string title, string description, string status)
        {
            if(string.IsNullOrEmpty(title)) throw new ArgumentNullException("Title is required.");
            if(string.IsNullOrEmpty(description)) throw new ArgumentNullException("Description is required.");
            Title=title;
            Description = description;
            Status = status;
        }
    }
}