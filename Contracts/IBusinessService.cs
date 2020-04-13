using Contracts.IBusinessServiceWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
  public interface IBusinessService
    {
        IPurchaseWrapperService PurchaseServiceWrapper { get; }
        IBusinessWrapperService BusinessWrapperService { get; }
    }
}
