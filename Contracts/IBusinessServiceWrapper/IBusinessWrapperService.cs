using CommonUtils;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IBusinessServiceWrapper
{
   public interface IBusinessWrapperService
    {
        Task<WrapperPaymentListVM> PayToSupplier(PaymentVM paymentVM);
        Task<WrapperPaymentListVM> PayToStaff(PaymentVM paymentVM);
        Task<WrapperPaymentListVM> RecieveFromCustomer(PaymentVM paymentVM);
        Task<WrapperCustomerHistory> GetCustomerHistory(CustomerVM customerVM);
        Task<WrapperSupplierHistory> GetSupplierHistory(SupplierVM supplierVM);
        Task<WrapperStaffHistory> GetStaffHistory(StaffVM staffVM); 
        Task<WrapperPaymentListVM> GetSupplierPaymentList(GetPaymentDataListVM vm);
        Task<WrapperPaymentListVM> DeleteSupplierPayment(PaymentVM vm);
        Task<WrapperPaymentListVM> GetStaffPaymentList(GetPaymentDataListVM vm);
        Task<WrapperPaymentListVM> DeleteStaffPayment(PaymentVM vm);
        Task<WrapperPaymentListVM> GetCustomerPaymentList(GetPaymentDataListVM vm);
        Task<WrapperPaymentListVM> DeleteCustomerPayment(PaymentVM vm);
    }
}
