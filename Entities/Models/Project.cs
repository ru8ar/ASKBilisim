using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Project : CoreEntitiy
    {
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerComment { get; set; }
        public string ProjectUrl { get; set; }
        public string Services { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string RequestDescription { get; set; }
        public string ResultDescription { get; set; }
        public int CategoryId { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
        public ICollection<ProjectImage> ProjectImages { get; set; }
        public ICollection<ProjectMobileImage> ProjectMobileImages { get; set; }
        public ICollection<ProjectRequestArticle> ProjectRequestArticles { get; set; }
        public ICollection<ProjectResultArticle> ProjectResultArticles { get; set; }



    }
}
