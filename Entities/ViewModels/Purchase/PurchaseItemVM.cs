using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class PurchaseItemVM
    {
        public string ItemcategoryId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
