﻿using Entities.ViewModels;
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
        Task AddPurchaseReturn(PurchaseReturnVM vm);
        Task<WrapperPurchaseListVM> GetAllPurchaseAsync(GetDataListVM getDataListVM);
        Task<WrapperPurchaseReturnVM> GetAllPurchaseReturn(GetDataListVM getDataListVM);
    }
}
