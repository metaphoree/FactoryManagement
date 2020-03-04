using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
   public interface ICustomerService
    {
        Task<WrapperListCustomerVM> Add(AddCustomerViewModel addCustomerViewModel);
        Task<WrapperListCustomerVM> Update(string id, UpdateCustomerViewModel updateCustomerViewModel);
        Task<List<ListCustomerVM>> GetList(string FactoryId);
        Task<UpdateCustomerViewModel> GetSingle(string cusId, string FactoryId);
        Task<WrapperListCustomerVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperListCustomerVM> Delete(UpdateCustomerViewModel customerTemp);
    }
}
