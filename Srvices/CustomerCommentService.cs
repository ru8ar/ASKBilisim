using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CustomerCommentService : BaseService<CustomerMessaage>,ICustomerCommentService
    {
        private ProjectContext _context;

        public CustomerCommentService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
