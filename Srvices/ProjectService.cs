using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class ProjectService : BaseService<Project>,IProjectService
    {
        private ProjectContext _context;

        public ProjectService(ProjectContext context) : base(context) 
        {
            _context = context;
        }

       
        
    }
}
