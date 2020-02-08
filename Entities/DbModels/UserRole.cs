using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class UserRole : BaseEntity
    {
 
        public string UserId { get; set; }
        public string RoleId { get; set; }

    }
}
