using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Models
{
    public class PostDTO
    {
        public Guid PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public string Date { get; set; }

        public ICollection<CommentDTO> Comments { get; set; }
    }
}
