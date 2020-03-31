using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Sales
{
  public  class SalesItemVM
    {
        public ItemVM Item { get; set; }
        public ItemStatusVM ItemStatus { get; set; }
        public ItemCategoryVM ItemCategory { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public string FactoryId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public CustomerVM CustomerVM { get; set; }
        public string EmployeeId { get; set; }
        public string InvoiceId { get; set; }

    }
}
