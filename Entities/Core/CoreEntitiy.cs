using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Core
{
    public class CoreEntitiy
    {
        public CoreEntitiy()
        {
            Id = Id++;
        }
        public int Id { get; set; }
    }
}
