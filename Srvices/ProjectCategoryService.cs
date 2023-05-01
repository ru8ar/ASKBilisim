using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProjectCategoryService : BaseService<ProjectCategory>, IProjectCategoryService
    {
        private ProjectContext _context;

        public ProjectCategoryService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
