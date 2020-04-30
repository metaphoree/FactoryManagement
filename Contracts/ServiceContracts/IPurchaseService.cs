using Entities.ViewModels;
using Entities.ViewModels.Purchase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IPurchaseService
    {
        Task<WrapperPurchaseListVM> AddPurchaseAsync(PurchaseVM purchaseVM);
        Task<WrapperPurchaseReturnVM> AddPurchaseReturnAsync(PurchaseReturnVM vm);
        Task<WrapperPurchaseListVM> DeletePurchaseAsync(PurchaseVM vm);
        Task<WrapperPurchaseReturnVM> DeletePurchaseReturnAsync(PurchaseReturnVM vm);
        Task<WrapperPurchaseListVM> GetAllPurchaseAsync(GetDataListVM getDataListVM);
        Task<WrapperPurchaseReturnVM> GetAllPurchaseReturnAsync(GetDataListVM getDataListVM);
    }
}
