using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProjectMobileImageService : BaseService<ProjectMobileImage>
    {
        private ProjectContext _context;
        public ProjectMobileImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public void SetFalse(List<ProjectMobileImage> projectMobileImages)
        {
            foreach (ProjectMobileImage projectMobileImage in projectMobileImages)
            {
                projectMobileImage.IsActive = false;
                Update(projectMobileImage);
            }
            Save();
        }
    }
}
