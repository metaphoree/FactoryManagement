using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Income
{
    public class WrapperMonthIncomeVM
    {
        public WrapperMonthIncomeVM()
        {
            ListOfData = new List<MonthlyIncome>();
        }

        public List<MonthlyIncome> ListOfData { get; set; }
        public long TotalRecords { get; set; }
    }
}
