using Entities.Models;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface ICustomerCommentImageService : IService<CustomerCommentImage>
    {
        void SetFalse(List<CustomerCommentImage> customerCommentImages);
    }
}
