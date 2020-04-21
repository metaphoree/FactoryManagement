using Entities.ViewModels;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Staff;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IStaffService
    {
        Task<WrapperStaffListVM> Add(StaffVM addCustomerViewModel);
        Task<WrapperStaffListVM> Update(string id, StaffVM updateCustomerViewModel);
        Task<WrapperStaffListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperStaffListVM> Delete(StaffVM customerTemp);
        Task<WrapperStaffHistory> GetStaffHistory(GetDataListHistory staffVM);

        Task<WrapperPaymentListVM> GetStaffPaymentList(GetPaymentDataListVM vm);
        Task<WrapperPaymentListVM> PayToStaff(PaymentVM paymentVM);
        Task<WrapperPaymentListVM> DeleteStaffPayment(PaymentVM vm);
        StaffHistory GetStaffHistoryOverview(WrapperStaffHistory list);
    }
}
