using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.InvoiceType
{
   public class WrapperInvoiceTypeListVM
    {
        public long TotalRecords { get; set; }
        public List<InvoiceTypeVM> ListOfData { get; set; }
    }
}
