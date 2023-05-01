using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class OfferService : BaseService<Offer>, IOfferService
    {
        private ProjectContext _context;

        public OfferService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
