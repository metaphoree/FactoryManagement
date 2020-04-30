using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Recievable
{
    public class MonthlyRecievable
    {
        public string ClientName { get; set; }
        public string InvoiceId { get; set; }
        public string Amount { get; set; }
        public string Month { get; set; }
        public string Purpose { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
