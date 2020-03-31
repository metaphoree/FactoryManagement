using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Purchase : BaseEntity
    {      
        public string ClientId { get; set; }
        public string InvoiceId { get; set; }

        public string ItemId { get; set; }
        public string ItemCategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Month { get; set; }
        public long Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
