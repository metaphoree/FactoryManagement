using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class PurchaseItemVM
    {
        public ItemVM Item { get; set;}
        public ItemStatusVM ItemStatus { get; set;}
        public ItemCategoryVM ItemCategory { get; set;}
        public int Quantity { get; set;}
        public double UnitPrice { get; set;}
        public string FactoryId { get; set;}
        public DateTime ExpiryDate { get; set; }
        public SupplierVM SupplierVM { get; set;}
        public string EmployeeId { get; set; }
        public string InvoiceId { get; set; }
    }
}
