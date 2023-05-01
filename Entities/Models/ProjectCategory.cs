using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ProjectCategory : CoreEntitiy
    {
        public string CategoryName { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Offer> Offers { get; set; }


    }
}
