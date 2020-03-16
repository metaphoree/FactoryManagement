using Entities.ViewModels;
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
        Task<WrapperSupplierListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperSupplierListVM> Delete(SupplierVM customerTemp);
    }
}
