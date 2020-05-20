using Entities.ViewModels.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IFactoryService
    {
        Task<WrapperFactoryListVM> Add(FactoryVM vm);
        Task<WrapperFactoryListVM> Delete(FactoryVM itemTemp);
        Task<WrapperFactoryListVM> GetListPaged(Entities.ViewModels.GetDataListVM dataListVM);
        Task<WrapperFactoryListVM> Update(string id, FactoryVM vm);
    }
}
