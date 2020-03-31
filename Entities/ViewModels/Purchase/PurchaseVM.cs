using Entities.DbModels;
using Entities.ViewModels.ExpenseType;
using Entities.ViewModels.InvoiceType;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class PurchaseVM
    {
        public SupplierVM SupplierVM { get; set; }

        public InvoiceTypeVM InvoiceType { get; set; }
        public ExpenseTypeVM ExpenseType { get; set; }
        public DateTime OcurranceDate { get; set; }
        public long TotalAmount { get; set; }
        public long PaidAmount { get; set; }
        public long DueAmount { get; set; }
        public long DiscountAmount { get; set; }
        public List<PurchaseItemVM> ItemList { get; set; }

        public string EmployeeId { get; set; }
        public string FactoryId { get; set; }

        public string InvoiceId { get; set; }

        //    public DateTime DeliveryDate { get; set; }
        //    public DateTime OrderIssued { get; set; }
        //    public long DiscountPercentage { get; set; }
        //    public long TaxAmount { get; set; }
        //    public long DeliveryCost { get; set; }
    }
}
