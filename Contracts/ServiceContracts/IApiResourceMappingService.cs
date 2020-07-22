using Entities.ViewModels.ApiResourceMapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IApiResourceMappingService
    {
        Task<ApiResourceMappingVM> GetApiResourceMappingAsync(string Controller, string ActionMethod);
        ApiResourceMappingVM GetApiResourceMapping(string Controller, string ActionMethod);
    
    }
}
