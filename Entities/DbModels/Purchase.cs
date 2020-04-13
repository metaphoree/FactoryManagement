﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime OccurranceDate { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

        //[ForeignKey("ItemCategoryId")]
        //public virtual ItemCategory ItemCategory { get; set; }
    }
}
