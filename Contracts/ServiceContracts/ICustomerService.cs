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
        Task<WrapperListCustomerVM> Add(CustomerVM addCustomerViewModel);
        Task<WrapperListCustomerVM> Update(string id, CustomerVM updateCustomerViewModel);
        //Task<List<CustomerVM>> GetList(string FactoryId);
        //Task<CustomerVM> GetSingle(string cusId, string FactoryId);
        Task<WrapperListCustomerVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperListCustomerVM> Delete(CustomerVM customerTemp);
    }
}
