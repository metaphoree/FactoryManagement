using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Payable
{
   public class WrapperMonthRecievableListVM
    {
        public WrapperMonthRecievableListVM()
        {
            ListOfData = new List<MonthlyPayable>();
        }

        public List<MonthlyPayable> ListOfData { get; set; }
        public long TotalRecoreds { get; set; }
    }
}
