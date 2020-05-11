using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Expense
{
   public class WrapperExpenseListVM
    {
        public List<ExpenseVM> ListOfData { get; set; }
        public long TotalRecords { get; set; }

        public WrapperExpenseListVM() { 
        
        }

    }
}
