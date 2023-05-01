using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class CustomerMessaage : CoreEntitiy
    {
        public string CustomerName { get; set; }
        public string Comment { get; set; }
        public string CustomerTitle { get; set; }
        public ICollection<CustomerCommentImage> CustomerCommentImages { get; set; }

    }
}
