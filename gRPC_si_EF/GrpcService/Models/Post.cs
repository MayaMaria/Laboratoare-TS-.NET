using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string Description { get; set; }

        public string Domain { get; set; }

        public string Date { get; set; }
    }
}
