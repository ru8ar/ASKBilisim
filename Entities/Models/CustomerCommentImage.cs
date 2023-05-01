using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class CustomerCommentImage : CoreEntitiy
    {
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int CustomerCommentId { get; set; }
        public virtual CustomerMessaage CustomerComment { get; set; }
    }
}
