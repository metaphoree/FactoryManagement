using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Role
{
   public  class WrapperRoleListVM
    {
        public long TotalRecords { get; set; }
        public List<RoleVM> ListOfData { get; set; }
    }
}
