using Entities.ViewModels;
using Entities.ViewModels.Department;
using Entities.ViewModels.EquipmentCategory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IDepartmentService
    {
        Task<WrapperDepartmentListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperDepartmentListVM> Add(DepartmentVM vm);
        Task<WrapperDepartmentListVM> Update(string id, DepartmentVM vm);
        Task<WrapperDepartmentListVM> Delete(DepartmentVM itemTemp);
    }
}
