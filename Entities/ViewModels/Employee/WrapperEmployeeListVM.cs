using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Employee
{
   public class WrapperEmployeeListVM
    {
        public long TotalRecoreds { get; set; }
        public List<EmployeeVM> ListOfData { get; set; }
    }
}
