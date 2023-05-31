using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppDiplom.Core.Models
{
   public class Comment
    {
        public string UserName { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CommentValue { get; set; }
    }
}
