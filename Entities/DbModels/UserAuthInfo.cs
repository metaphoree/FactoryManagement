using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class UserAuthInfo : BaseEntity
    {
      
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
