using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Staff
{
   public class WrapperStaffListVM
    {
        public long TotalRecoreds { get; set; }
        public List<StaffVM> ListOfData { get; set; }
    }
}
