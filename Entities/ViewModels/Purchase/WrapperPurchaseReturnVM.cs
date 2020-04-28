using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Purchase
{
   public class WrapperPurchaseReturnVM
    {

        public WrapperPurchaseReturnVM() {
            this.ListOfData = new List<PurchaseReturnVM>();

        }

        public List<PurchaseReturnVM> ListOfData { get; set; }
        public int NumberOfRecords { get; set; }

    }
}
