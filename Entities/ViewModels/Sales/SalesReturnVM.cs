using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Sales
{
    public class SalesReturnVM
    {
        public string CustomerId { get; set; }
        public string ItemId { get; set; }
        public string ItemCategoryId { get; set; }


        public long UnitPrice { get; set; }
        public long Quantity { get; set; }
        public string EmployeeId { get; set; }
        public string FactoryId { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceTypeId { get; set; }
    }
}
