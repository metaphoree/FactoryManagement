using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class WrapperPurchaseListVM : CommonVM
    {
        public long TotalRecords { get; set; }
        public List<PurchaseVM> ListOfData { get; set; }

    }
}
