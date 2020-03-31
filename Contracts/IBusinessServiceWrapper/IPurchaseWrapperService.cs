using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IBusinessServiceWrapper
{
   public interface IPurchaseWrapperService
    {
        Task<InitialLoadDataVM> GetPurchaseInitialData(GetDataListVM getDataListVM);
        Task<InitialLoadDataVM> GetSalesInitialData(GetDataListVM getDataListVM);
    }
}
