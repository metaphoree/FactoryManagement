﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DbModels
{
    public  class Payable : BaseEntity
    {
        public string Purpose { get; set; }
      //  public string PurposeTypeId { get; set; }    
        public string ClientId { get; set; }
        public string InvoiceId { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public string ProductionId { get; set; }


        [ForeignKey("ClientId")]
        public Supplier Supplier { get; set; }

        [ForeignKey("ClientId")]
        public Customer Customer { get; set; }

        [ForeignKey("ClientId")]
        public Staff Staff { get; set; }


    }
}
