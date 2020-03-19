using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Purchase : BaseEntity
    {      
        public string ClientId { get; set; }
        public string InvoiceId { get; set; }
        public string ProductId { get; set; }
        public decimal UnitPrice { get; set; }
     //   public string Month { get; set; }
        public long Quantity { get; set; }
          public decimal Amount { get; set; }
        // public decimal AmountBeforeDiscount { get; set; }
        //  public decimal AmountPaid { get; set; }
        //  public decimal AmountDue { get; set; }
        //   public decimal AmountAfterDiscount { get; set; }
        //   public bool? IsDiscountInPercentage { get; set; }
        //  public bool? IsPaid { get; set; }
        //  public string Description { get; set; }
        //  public DateTime SalesDate { get; set; }
        //    public string EmployeeId { get; set; }
        //   public string PurchaseId { get; set; }
        //  public decimal? Discount { get; set; }
    }
}
