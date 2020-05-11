using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Staff
{
   public class WrapperStaffHistory
    {

        public WrapperStaffHistory()
        {
            ListOfData = new List<StaffHistory>();
            TotalRecords = 0;
        }
        public long TotalRecords { get; set; }
        public List<StaffHistory> ListOfData { get; set; }
    }
}
