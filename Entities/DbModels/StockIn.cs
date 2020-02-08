using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class StockIn : BaseEntity
    {
      
        public string ItemId { get; set; }
        public string SupplierId { get; set; }
        public string InvoiceId { get; set; }
        public string BatchNumber { get; set; }
        public long? Quantity { get; set; }
        public decimal? Unitprice { get; set; }
        public string ItemStatusId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime AddedDateTime { get; set; }
    }
}
