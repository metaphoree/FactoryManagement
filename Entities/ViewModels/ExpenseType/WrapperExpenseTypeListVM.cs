using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ExpenseType
{
    public class WrapperExpenseTypeListVM
    {
        public long TotalRecords { get; set; }
        public List<ExpenseTypeVM> ListOfData { get; set; }
    }
}
