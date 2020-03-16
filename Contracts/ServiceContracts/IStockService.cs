using Entities.ViewModels;
using Entities.ViewModels.Stock;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IStockService
    {
        Task<WrapperStockListVM> Add(StockVM ViewModel);
        Task<WrapperStockListVM> Update(string id, StockVM ViewModel);
        Task<WrapperStockListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperStockListVM> Delete(StockVM customerTemp);

    }
}
