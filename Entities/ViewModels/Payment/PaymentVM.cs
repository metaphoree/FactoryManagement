using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Payment
{
   public class PaymentVM
    {
        public string InvoiceId { get; set; }
        public string InvoiceTypeId { get; set; }
        public string FactoryId { get; set; }
        public string EmployeeId { get; set; }
        public string ClientId { get; set; }
        public long Amount { get; set; }
        public string TypeId { get; set; }
    }
}
