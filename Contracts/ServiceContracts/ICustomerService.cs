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
        Task<bool> AddCustomer(AddCustomerViewModel addCustomerViewModel);
        Task<bool> UpdateCustomer(string id, UpdateCustomerViewModel updateCustomerViewModel);
        Task<List<ListCustomerVM>> GetCustomerList(string FactoryId);
        Task<UpdateCustomerViewModel> GetCustomer(string cusId, string FactoryId);
        Task<WrapperListCustomerVM> GetCustomerListPaged(GetDataListVM dataListVM);
    }
}
