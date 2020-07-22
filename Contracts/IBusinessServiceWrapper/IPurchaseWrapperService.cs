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
        Task<InitialLoadDataVM> GetPaymentInitialData(GetDataListVM getDataListVM);
        Task<InitialLoadDataVM> GetProductionInitialData(GetDataListVM getDataListVM);
        Task<InitialLoadDataVM> GetStaffInitialData(GetDataListVM getDataListVM);
    }
}
