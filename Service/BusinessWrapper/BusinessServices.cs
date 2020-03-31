using Contracts;
using Contracts.IBusinessServiceWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessWrapper
{
   public class BusinessServices : IBusinessService
    {

        public IPurchaseWrapperService _PurchaseWrapperService;

        public BusinessServices(IPurchaseWrapperService PurchaseWrapperService) {
            this._PurchaseWrapperService = PurchaseWrapperService;        
        }

        public IPurchaseWrapperService PurchaseServiceWrapper
        {
            get {
                return _PurchaseWrapperService;            
            }               
        }
    }
}
