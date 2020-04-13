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
        Task<CommonResponse> PayToSupplier(PaymentVM paymentVM);
        Task<CommonResponse> PayToWorker(PaymentVM paymentVM);
        Task<CommonResponse> RecieveFromCustomer(PaymentVM paymentVM);

        Task<WrapperCustomerHistory> GetCustomerHistory(CustomerVM customerVM);
        Task<WrapperSupplierHistory> GetSupplierHistory(SupplierVM supplierVM);
        Task<WrapperStaffHistory> GetStaffHistory(StaffVM staffVM);
    }
}
