using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Income
{
   public  class WrapperIncomeListVM
    {
        public long TotalRecords { get; set; }
        public List<IncomeVM> ListOfData { get; set; }
    }
}
