using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCGrid.Models
{
    public class Post
    {
        public int id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } 
    }
}
