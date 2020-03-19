using Entities.ViewModels;
using Entities.ViewModels.InvoiceType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IInvoiceTypeService
    {
        Task<WrapperInvoiceTypeListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperInvoiceTypeListVM> Add(InvoiceTypeVM vm);
        Task<WrapperInvoiceTypeListVM> Update(string id, InvoiceTypeVM vm);
        Task<WrapperInvoiceTypeListVM> Delete(InvoiceTypeVM itemTemp);

    }
    
}
