using Entities.ViewModels.Auth;
using Entities.ViewModels.UserAuthInfo;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IUserAuthInfoService
    {
        Task<WrapperUserAuthInfoListVM> Add(UserAuthInfoVM vm);
        JwtSecurityToken DecodeJwtToken(string token);
        Task<WrapperUserAuthInfoListVM> Delete(UserAuthInfoVM itemTemp);
        Task<WrapperUserAuthInfoListVM> GetListPaged(Entities.ViewModels.GetDataListVM dataListVM);
        LoginResponseVM IsUserAuthentic(LoginVM loginVM);
        bool IsUserExist(LoginVM loginVM);
        Task<WrapperUserAuthInfoListVM> Update(string id, UserAuthInfoVM vm);
        bool ValidateCurrentToken(string token);
    }
}
