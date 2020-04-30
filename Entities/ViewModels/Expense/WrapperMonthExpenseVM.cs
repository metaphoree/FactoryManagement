using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Expense
{


    public class WrapperMonthExpenseVM
    {
        public WrapperMonthExpenseVM()
        {
            ListOfData = new List<MonthlyExpense>();
        }

        public List<MonthlyExpense> ListOfData { get; set; }
        public long TotalRecoreds { get; set; }
    }



}
