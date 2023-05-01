using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CustomerCommentImageService : BaseService<CustomerCommentImage>, ICustomerCommentImageService
    {
        private ProjectContext _context;

        public CustomerCommentImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public void SetFalse(List<CustomerCommentImage> customerCommentImages)
        {
            foreach (CustomerCommentImage customerCommentImage in customerCommentImages)
            {
                customerCommentImage.IsActive = false;
                Update(customerCommentImage);
            }
            Save();
        }
    }
}
