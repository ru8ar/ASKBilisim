using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ReferenceImageService : BaseService<ReferenceImage>, IReferenceImageService
    {
        private ProjectContext _context;

        public ReferenceImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public void SetFalse(List<ReferenceImage> referenceImages)
        {
            foreach (ReferenceImage referenceImage in referenceImages)
            {
                referenceImage.IsActive = false;
                Update(referenceImage);
            }
            Save();
        }
    }
}
