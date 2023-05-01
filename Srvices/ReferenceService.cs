using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ReferenceService : BaseService<Reference>, IReferenceService
    {
        private ProjectContext _context;

        public ReferenceService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
