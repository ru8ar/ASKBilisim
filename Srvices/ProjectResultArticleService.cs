using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProjectResultArticleService : BaseService<ProjectResultArticle>, IProjectResultArticleService
    {
        private ProjectContext _context;

        public ProjectResultArticleService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
