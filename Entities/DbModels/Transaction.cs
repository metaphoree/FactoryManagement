using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Transaction : BaseEntity
    {      
        public string InvoiceId { get; set; }
        public string Amount { get; set; }
        public string ExecutorId { get; set; }
        public string ClientId { get; set; }
        public string PaymentStatusId { get; set; }
        public string Description { get; set; }
        public string TransactionTypeId { get; set; }
        public string Month { get; set; }
        public string Purpose { get; set; }
        public string TransactionId { get; set; }
    }
}
