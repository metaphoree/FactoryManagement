using Entities.ViewModels;
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
    }
}
