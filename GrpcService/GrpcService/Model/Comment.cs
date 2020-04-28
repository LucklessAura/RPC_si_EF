using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Model
{
    public class Comment
    {

        public int CommentId { get; set; }

        public string Text { get; set; }

        public int PostPostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
