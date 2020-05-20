using Entities.ViewModels.PaymentStatus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IPaymentStatusService
    {
        Task<WrapperPaymentStatusListVM> Add(PaymentStatusVM vm);
        Task<WrapperPaymentStatusListVM> Delete(PaymentStatusVM itemTemp);
        Task<WrapperPaymentStatusListVM> GetListPaged(Entities.ViewModels.GetDataListVM dataListVM);
        Task<WrapperPaymentStatusListVM> Update(string id, PaymentStatusVM vm);
    }
}
