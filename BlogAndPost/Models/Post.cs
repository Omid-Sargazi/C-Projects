using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAndPost.Models
{
    public class Post
    {
        public Guid PostId { get; set; }= Guid.NewGuid();
        public string Content { get; set; }
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}