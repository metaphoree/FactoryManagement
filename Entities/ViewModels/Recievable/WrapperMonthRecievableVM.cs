using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Recievable
{
    public class WrapperMonthRecievableVM
    {
        public WrapperMonthRecievableVM()
        {
            ListOfData = new List<MonthlyRecievable>();
        }

        public List<MonthlyRecievable> ListOfData { get; set; }
        public long TotalRecoreds { get; set; }
    }
}
