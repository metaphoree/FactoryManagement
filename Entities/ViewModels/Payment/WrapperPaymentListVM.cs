using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Payment
{
    public class WrapperPaymentListVM
    {
        public long TotalRecords { get; set; }
        public List<PaymentVM> ListOfData { get; set; }
    }
}
