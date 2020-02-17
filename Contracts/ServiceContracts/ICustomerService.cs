using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
   public interface ICustomerService
    {
        Task AddCustomer(AddCustomerViewModel addCustomerViewModel);
    }
}
