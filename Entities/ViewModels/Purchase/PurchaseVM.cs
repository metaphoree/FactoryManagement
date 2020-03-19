using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class PurchaseVM
    {
        public string ClientId { get; set; } 
        public DateTime OcurranceDate { get; set; }
        public long TotalAmount { get; set; }
        public long PaidAmount { get; set; }
        public long DueAmount { get; set; }
        public long DiscountAmount { get; set; }
     //   public long DiscountPercentage { get; set; }

      //  public long TaxAmount { get; set; }

    //    public long DeliveryCost { get; set; }
        List<PurchaseItemVM> ItemList { get; set; }

      //  public DateTime DeliveryDate { get; set; }
      //  public DateTime OrderIssued { get; set; }

    }
}
