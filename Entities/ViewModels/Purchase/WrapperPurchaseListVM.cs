using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class WrapperPurchaseListVM
    {
        public long TotalRecoreds { get; set; }
        public List<PurchaseVM> ListOfData { get; set; }

    }
}
