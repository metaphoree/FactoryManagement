using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Staff
{
   public class WrapperStaffHistory
    {
        public long TotalRecoreds { get; set; }
        public List<StaffHistory> ListOfData { get; set; }
    }
}
