using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Model
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }

        public string Description { get; set; }

        public string Domain { get; set; }

        public System.DateTime Date { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
