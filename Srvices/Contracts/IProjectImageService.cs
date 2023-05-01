using Entities.Models;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Contracts
{
    public interface IProjectImageService : IService<ProjectImage>
    {
        void SetFalse(List<ProjectImage> projectImages);    
      
    }
}
