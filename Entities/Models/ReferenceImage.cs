using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ReferenceImage : CoreEntitiy
    {
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
