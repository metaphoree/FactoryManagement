using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.IncomeType
{
    public class WrapperIncomeTypeListVM
    {
        public long TotalRecords { get; set; }
        public List<IncomeTypeVM> ListOfData { get; set; }
    }
}
