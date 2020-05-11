using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Department
{
    public class WrapperDepartmentListVM
    {
        public long TotalRecords { get; set; }
        public List<DepartmentVM> ListOfData { get; set; }
    }
}
