using Entities.ViewModels;
using Entities.ViewModels.Role;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IRoleService
    {
        Task<WrapperRoleListVM> Add(RoleVM vm);
        Task<WrapperRoleListVM> Delete(RoleVM itemTemp);
        Task<WrapperRoleListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperRoleListVM> Update(string id, RoleVM vm);
    }
}
