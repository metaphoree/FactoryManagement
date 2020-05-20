using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.PaymentStatus
{
   public class WrapperPaymentStatusListVM
    {
        public long TotalRecords { get; set; }
        public List<PaymentStatusVM> ListOfData { get; set; }

    }
}
