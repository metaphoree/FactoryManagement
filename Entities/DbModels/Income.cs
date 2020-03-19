using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DbModels
{
   public  class Income : BaseEntity
    {
        public string IncomeTypeId { get; set; }
        public string ClientId { get; set; }
        public string InvoiceId { get; set; }
        public string Month { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public DateTime? OccurranceDate { get; set; }
        public string EmployeeId { get; set; }

    }
}
