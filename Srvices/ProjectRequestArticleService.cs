using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProjectRequestArticleService : BaseService<ProjectRequestArticle>, IProjectRequestArticleService
    {
        private ProjectContext _context;

        public ProjectRequestArticleService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
