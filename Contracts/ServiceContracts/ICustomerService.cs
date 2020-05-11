using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Payment;
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
        Task<WrapperListCustomerVM> GetListPaged(GetDataListVM dataListVM, bool withHistory);
        Task<WrapperListCustomerVM> Delete(CustomerVM customerTemp);
        Task<WrapperCustomerHistory> GetCustomerHistory(GetDataListHistory customerVM);
        Task<WrapperPaymentListVM> GetCustomerPaymentList(Entities.ViewModels.Payment.GetPaymentDataListVM vm);
        Task<WrapperPaymentListVM> RecieveFromCustomer(Entities.ViewModels.Payment.PaymentVM paymentVM);
        Task<WrapperPaymentListVM> DeleteCustomerPayment(Entities.ViewModels.Payment.PaymentVM vm);
        CustomerHistory GetCustomerHistoryOverview(WrapperCustomerHistory list);
    }
}
