using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Models
{
    public class CommentDTO
    {
        public Guid CommentId { get; set; }
        public string Text { get; set; }
        public Guid PostPostId { get; set; }
    }
}
