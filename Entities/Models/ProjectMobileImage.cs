using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ProjectMobileImage : CoreEntitiy
    {
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
