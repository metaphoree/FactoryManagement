using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Stock : BaseEntity
    {
      
        public string ItemId { get; set; }
        public long? Quantity { get; set; }
        public string ItemStatusId { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
