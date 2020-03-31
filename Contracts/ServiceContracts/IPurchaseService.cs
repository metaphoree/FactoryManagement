using Entities.ViewModels.Purchase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IPurchaseService
    {
        Task AddPurchaseAsync(PurchaseVM purchaseVM);
    }
}
