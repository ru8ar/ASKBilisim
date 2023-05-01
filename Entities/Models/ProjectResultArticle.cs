using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ProjectResultArticle : CoreEntitiy
    {
        public string Article { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
