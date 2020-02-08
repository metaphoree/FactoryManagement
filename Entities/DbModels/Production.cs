using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Production : BaseEntity
    {
     
        public string StaffId { get; set; }
        public string ProductId { get; set; }
        public long Quantity { get; set; }
        public string MachineId { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal RatePerProduct { get; set; }
        public decimal TotalAmount { get; set; }
        public bool? IsMadeJointly { get; set; }
        public string ProductionId { get; set; }
    }
}
