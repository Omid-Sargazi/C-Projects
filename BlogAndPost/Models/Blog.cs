using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAndPost.Models
{
    public class Blog
    {
        public Guid BlogId { get; set; }= Guid.NewGuid();
        public string Title { get; set; }
        public List<Post> Posts{ get; set; } = new();
    }
}