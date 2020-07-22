using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public UserRoleService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._utilService = utilService;
        }


        public  UserRole GetUserRole(string UserId)
        {
            var userRole = _repositoryWrapper
                .UserRole
                .FindAll()
                .Where(x => x.UserId == UserId)
                .Include(x => x.UserAuthInfo)
                .Include(x => x.Role)
                .ToList().FirstOrDefault();
            return userRole; 
        }
        public async Task<UserRole> GetUserRoleAsync(string UserId)
        {
            var userRole = await _repositoryWrapper
                .UserRole
                .FindAll()
                .Where(x => x.UserId == UserId)
                .Include(x => x.UserAuthInfo)
                .Include(x => x.Role)
                .ToListAsync();

            return userRole.FirstOrDefault();
        }
    }
}
