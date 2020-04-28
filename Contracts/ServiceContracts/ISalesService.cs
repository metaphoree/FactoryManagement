using Entities.ViewModels;
using Entities.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface ISalesService
    {
        Task<WrapperSalesListVM> AddSalesAsync(SalesVM salesVM);
        Task<WrapperSalesReturnVM> AddSalesReturn(SalesReturnVM vm);
        Task<WrapperSalesListVM> GetAllSalesAsync(GetDataListVM getDataListVM);
        Task<WrapperSalesReturnVM> GetAllSalesReturn(GetDataListVM getDataListVM);
    }
}
