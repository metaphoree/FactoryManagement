using Entities.ViewModels;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface ISupplierService
    {
        Task<WrapperSupplierListVM> Add(SupplierVM ViewModel);
        Task<WrapperSupplierListVM> Update(string id, SupplierVM ViewModel);
        Task<WrapperSupplierListVM> GetListPaged(GetDataListVM dataListVM, bool withHistory);
        Task<WrapperSupplierListVM> Delete(SupplierVM customerTemp);



        Task<WrapperPaymentListVM> GetSupplierPaymentList(GetPaymentDataListVM vm);

        Task<WrapperPaymentListVM> DeleteSupplierPayment(PaymentVM vm);
        Task<WrapperPaymentListVM> PayToSupplier(PaymentVM paymentVM);
        Task<WrapperSupplierHistory> GetSupplierHistory(GetDataListHistory supplierVM);
        SupplierHistory GetSupplierHistoryOverview(WrapperSupplierHistory list);
    }
}
