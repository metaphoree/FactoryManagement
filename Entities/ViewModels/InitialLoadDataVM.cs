using Entities.ViewModels.CustomerView;
using Entities.ViewModels.ExpenseType;
using Entities.ViewModels.IncomeType;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
  public  class InitialLoadDataVM
    {
        public List<ItemVM> ItemVMs { get; set; }
        public List<ItemCategoryVM> ItemCategoryVMs { get; set; }
        public List<CustomerVM> CustomerVMs { get; set; }
        public List<SupplierVM> SupplierVMs { get; set; }

        public List<ItemStatusVM> ItemStatusVMs { get; set; }
        public List<ExpenseTypeVM> ExpenseTypeVMs { get; set; }

        public List<IncomeTypeVM> IncomeTypeVMs { get; set; }

    }
}
