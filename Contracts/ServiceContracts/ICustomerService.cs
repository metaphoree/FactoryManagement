using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.ServiceContracts
{
   public interface ICustomerService
    {
        void AddCustomer(AddCustomerViewModel addCustomerViewModel);
    }
}
