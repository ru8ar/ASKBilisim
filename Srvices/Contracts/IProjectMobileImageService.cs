using Entities.Models;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IProjectMobileImageService : IService<ProjectMobileImage>
    {
        void SetFalse(List<ProjectMobileImage> projectMobileImages);
    }
}
