﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
      
        public string Text { get; set; }
    
        public int PostPostId { get; set; }
    }
}
