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

        public decimal Total_TillNow { get; set; }
        public decimal Total_Monthly { get; set; }
        public List<MonthlyRecievable> ListOfData { get; set; }
        public long TotalRecords { get; set; }
    }
}
