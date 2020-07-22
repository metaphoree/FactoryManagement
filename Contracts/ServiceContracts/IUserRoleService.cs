using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IUserRoleService
    {
        UserRole GetUserRole(string UserId);
        Task<UserRole> GetUserRoleAsync(string UserId);
    }
}
