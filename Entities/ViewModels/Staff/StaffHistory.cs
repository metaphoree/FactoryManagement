using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Staff
{
    public class StaffHistory
    {
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string InvoiceId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; }
        public long PaidAmount { get; set; }
        public long RecievedAmount { get; set; }
        public long PayableAmount { get; set; }
        public long RecievableAmount { get; set; }
        public long InvoiceTotalAfterDiscount { get; set; }
        public DateTime OccurranceDate { get; set; }
        public string Type { get; set; }
    }
}
