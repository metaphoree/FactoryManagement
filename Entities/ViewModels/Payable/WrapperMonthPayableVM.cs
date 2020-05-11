using Entities.ViewModels.Recievable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Payable
{
   public class WrapperMonthPayableListVM
    {
        public WrapperMonthPayableListVM()
        {
            ListOfData = new List<MonthlyPayable>();
        }

        public List<MonthlyPayable> ListOfData { get; set; }
        public long TotalRecords { get; set; }
    }
}
