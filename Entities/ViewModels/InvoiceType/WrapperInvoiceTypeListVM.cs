using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.InvoiceType
{
   public class WrapperInvoiceTypeListVM
    {
        public long TotalRecoreds { get; set; }
        public List<InvoiceTypeVM> ListOfData { get; set; }
    }
}
