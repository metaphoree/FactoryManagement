using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ExpenseType
{
    public class WrapperExpenseTypeListVM
    {
        public long TotalRecoreds { get; set; }
        public List<ExpenseTypeVM> ListOfData { get; set; }
    }
}
